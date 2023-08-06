using PKM.XRM.SecurityManager.Common;
using PKM.XRM.SecurityManager.DataModelLayer;
using PKM.XRM.SecurityManager.ServiceLayer;
using PKM.XRM.SecurityManager.UI.Helpers;
using PKM.XRM.SecurityManager.UI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKM.XRM.SecurityManager.UI.Presenter
{
    public class MultiSelectPresenter<P, T, S> : BasePresenter where P : BaseModel where T : BaseModel where S : IAssociationService<T>
    {
        private List<P> selectedPrimaryEntities;
        IMultiSelectView view;
        S service;
        private BindingSource assignedBindingSource;
        private BindingSource availableBindingSource;
        IEnumerable<BaseAssociationModel> allAssigned;
        IEnumerable<T> all;
        IEnumerable<T> displayedAssigned;
        IEnumerable<T> displayedAvailable;
        private string associationTableName;
        private string primaryTableName;

        public List<P> SelectedPrimaryEntities
        {
            get
            {
                return selectedPrimaryEntities;
            }
            set
            {
                selectedPrimaryEntities = value;
                if (selectedPrimaryEntities != null && selectedPrimaryEntities.Count > 0)
                {
                    if (string.IsNullOrWhiteSpace(primaryTableName) && value != null)
                    {
                        primaryTableName = value.First().EntityLogicalName;
                        SetAssociationTableName();
                    }

                    PrimaryEntitySelectionChanged();
                }
                else
                {
                    assignedBindingSource.DataSource = null;
                    availableBindingSource.DataSource = null;
                    view.AvailableCount = 0;
                    view.AssignedCount = 0;
                }
            }
        }

        public bool FilerBySelecetedPrimaryEntityBU { get; set; }

        public event EventHandler AssignmentChanged;

        public MultiSelectPresenter(string name, IMultiSelectView view, S service)
        {
            this.service = service;
            this.view = view;
            this.view.MultiSelectName = name;
            assignedBindingSource = new BindingSource();
            availableBindingSource = new BindingSource();
            this.view.SetAssignedBindingSource(assignedBindingSource);
            this.view.SetAvailableBindingSource(availableBindingSource);
            this.view.AssignAll += AssignAll;
            this.view.AssignSelected += AssignSelected;
            this.view.RemoveAll += RemoveAll;
            this.view.RemoveSelected += RemoveSelected;
            this.view.EmptyGridMessage = "No records found.";
        }

        public void HideBusinessUniteColumn()
        {
            view.HideBusinessUniteColumn();
        }

        private void AssignAll(object sender, EventArgs e)
        {
            var selectedAvailableIds = displayedAvailable.Select(a => a.Id).ToList();
            Assign(selectedAvailableIds);
        }

        private void AssignSelected(object sender, EventArgs e)
        {
            var selectedAvailableIds = this.view.GetSelectedAvailable();
            Assign(selectedAvailableIds);
        }

        private void RemoveAll(object sender, EventArgs e)
        {
            Remove(allAssigned);
        }

        private void RemoveSelected(object sender, EventArgs e)
        {
            var selectedAssignedIds = this.view.GetSelectedAssigned();
            Remove(allAssigned.Where(a => selectedAssignedIds.Contains(a.OtherEntity.Id)).ToList());
        }

        private void PrimaryEntitySelectionChanged()
        {
            if (SelectedPrimaryEntities.Count() >= 1)
            {
                try
                {
                    FetchData();
                    DisplayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FetchData()
        {
            //Guid selectedBUId = string.IsNullOrWhiteSpace(view.SelectedBU) ? Guid.Empty : new Guid(view.SelectedBU);
            Guid selectedBUId = FilerBySelecetedPrimaryEntityBU? SelectedPrimaryEntities.Select(a => a.BusinessUnitId).FirstOrDefault(): default(Guid);
            all = service.FetchAllRecords(selectedBUId);
            allAssigned = service.FetchAssociationTableRecords(SelectedPrimaryEntities.First().EntityLogicalName, SelectedPrimaryEntities.Select(a => a.Id).ToList());
        }

        private void DisplayData()
        {
            IEnumerable<(Guid Key, int Count)> commonAssigned = null;
            displayedAssigned = allAssigned.Select(a => a.OtherEntity as T).Distinct().OrderBy(a => a.Name);
            commonAssigned = allAssigned.GroupBy(a => a.OtherEntity, (otherEntity, associations) => new { Key = otherEntity.Id, Count = associations.Count() }).AsEnumerable().Select(a => (Key: a.Key, Count: a.Count));

            assignedBindingSource.DataSource = IEnumerableToDataTable.ToDataTable<T>(displayedAssigned);
            view.AssignedCount = displayedAssigned.Count();
            List<T> commonToAllUsers = new List<T>();
            List<Guid> commonAssignedToAllUsersIds = new List<Guid>();
            foreach (var result in commonAssigned)
            {
                if (result.Count == SelectedPrimaryEntities.Count())
                {
                    commonAssignedToAllUsersIds.Add(result.Key);
                    commonToAllUsers.Add(all.Where(a => a.Id == result.Key).First());
                }
            }

            displayedAvailable = all.Except(commonToAllUsers).OrderBy(a => a.Name).ToList();
            var available = IEnumerableToDataTable.ToDataTable<T>(displayedAvailable);
            availableBindingSource.DataSource = available;
            view.AvailableCount = available.Rows.Count;

            if (SelectedPrimaryEntities.Count() > 1 && commonAssignedToAllUsersIds.Count > 0)
            {
                view.HighlightCommonAssigned(commonAssignedToAllUsersIds);
            }
        }

        private void Assign(List<Guid> selectedAvailableIds)
        {
            if (SelectedPrimaryEntities != null && SelectedPrimaryEntities.Count() > 0 && selectedAvailableIds != null && selectedAvailableIds.Count() > 0)
            {
                List<BaseAssociationModel> associations = new List<BaseAssociationModel>();
                var toBeChecked = displayedAssigned.Where(a => selectedAvailableIds.Contains(a.Id)).Count();
                foreach (P primaryEntity in SelectedPrimaryEntities)
                {
                    foreach (Guid id in selectedAvailableIds)
                    {
                        if (toBeChecked > 0 && allAssigned.Where(a => a.PrimaryEntity.Id == primaryEntity.Id && a.OtherEntity.Id == id).Count() > 0)
                        {
                            continue;
                        }

                        associations.Add(new BaseAssociationModel() { EntityLogicalName = associationTableName, PrimaryEntity = primaryEntity, PrimaryEntityLogicalName = primaryEntity.EntityLogicalName, OtherEntity = all.Where(a => a.Id == id).First() });
                    }
                }

                RunAsync("Adding Association...",
                () =>
                {
                    service.UpdatedAssociationTableRecords(associations, true);
                },
                () =>
                {
                    PrimaryEntitySelectionChanged();
                    AssignmentChanged?.Invoke(this, EventArgs.Empty);
                },
                (error) =>
                {
                    ShowErrorMessage(error);
                });
            }
        }

        private void Remove(IEnumerable<BaseAssociationModel> associations)
        {
            if (SelectedPrimaryEntities != null && SelectedPrimaryEntities.Count() > 0 && associations != null && associations.Count() > 0)
            {
                RunAsync("Removing Association...",
                 () =>
                 {
                     service.UpdatedAssociationTableRecords(associations, false);
                 },
                 () =>
                 {
                     PrimaryEntitySelectionChanged();
                     AssignmentChanged?.Invoke(this, EventArgs.Empty);
                 },
                 (error) =>
                 {
                     ShowErrorMessage(error);
                 });
            }
        }

        private void SetAssociationTableName()
        {
            if (primaryTableName == Constants.UserTableName)
            {
                if (this.view.MultiSelectName == Constants.MultiSelectRoles)
                {
                    associationTableName = Constants.UserRoleAssociationTable;
                    view.EmptyGridMessage = "No records found (This features works if all selected useres are from same business unit)";
                }
                else if (this.view.MultiSelectName == Constants.MultiSelectTeams)
                {
                    associationTableName = Constants.UserTeamAssociationTable;
                }
                else if (this.view.MultiSelectName == Constants.MultiSelectFSPs)
                {
                    associationTableName = Constants.UserFSPAssociationTable;
                }
            }
            else if (primaryTableName == Constants.TeamTableName)
            {
                if (this.view.MultiSelectName == Constants.MultiSelectRoles)
                {
                    associationTableName = Constants.TeamRoleAssociationTable;
                    view.EmptyGridMessage = "No records found (This features works if all selected teams are from same business unit)";
                }
                else if (this.view.MultiSelectName == Constants.MultiSelectUsers)
                {
                    associationTableName = Constants.UserTeamAssociationTable;
                }
                else if (this.view.MultiSelectName == Constants.MultiSelectFSPs)
                {
                    associationTableName = Constants.TeamFSPAssociationTable;
                }
            }
            else if (primaryTableName == Constants.FieldSecurityProfileTableName)
            {
                if (this.view.MultiSelectName == Constants.MultiSelectUsers)
                {
                    associationTableName = Constants.UserFSPAssociationTable;
                }
                else if (this.view.MultiSelectName == Constants.MultiSelectTeams)
                {
                    associationTableName = Constants.TeamFSPAssociationTable;
                }
            }
            else if (primaryTableName == Constants.RoleTableName)
            {
                if (this.view.MultiSelectName == Constants.MultiSelectUsers)
                {
                    associationTableName = Constants.UserRoleAssociationTable;
                }
                else if (this.view.MultiSelectName == Constants.MultiSelectTeams)
                {
                    associationTableName = Constants.TeamRoleAssociationTable;
                }
            }
        }
    }
}
