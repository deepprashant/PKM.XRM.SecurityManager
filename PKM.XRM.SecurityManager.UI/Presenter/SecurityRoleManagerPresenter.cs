using PKM.XRM.SecurityManager.Common;
using PKM.XRM.SecurityManager.DataModelLayer;
using PKM.XRM.SecurityManager.ServiceLayer;
using PKM.XRM.SecurityManager.UI.Helpers;
using PKM.XRM.SecurityManager.UI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PKM.XRM.SecurityManager.UI.Presenter
{
    public class SecurityRoleManagerPresenter : BasePresenter
    {
        private ISecurityRoleManagerView view;
        private RoleService<RoleModel> roleService;
        private BindingSource businessUnitBindingSource;
        private BindingSource roleBindingSource;
        private IEnumerable<RoleModel> roles;
        private IEnumerable<BusinessUnitModel> businessUnits;
        private string nameSearchPhrase;
        private List<RoleModel> selectedRoles;
 
        MultiSelectPresenter<RoleModel, UserModel, UserService<UserModel>> userPresenter;
        MultiSelectPresenter<RoleModel, TeamModel, TeamService<TeamModel>> teamPresenter;

        public SecurityRoleManagerPresenter(ISecurityRoleManagerView view, RoleService<RoleModel> roleService)
        {
            this.businessUnitBindingSource = new BindingSource();
            this.roleBindingSource = new BindingSource();
            this.view = view;
            this.roleService = roleService;
            this.view.SearchPrimaryEntity += SearchPrimaryEntityEvenHandler;
            LoadBusinessUnits();
            this.view.SetBusinessUnitBindingSource(businessUnitBindingSource);
            this.view.SetRolesBindingSource(roleBindingSource);
            InitialIzeControls();
        }

        private void LoadBusinessUnits()
        {
            businessUnits = roleService.GetBusinessUnits(); ;
            businessUnitBindingSource.DataSource = businessUnits;
        }

        private void InitialIzeControls()
        {
            userPresenter = new MultiSelectPresenter<RoleModel, UserModel, UserService<UserModel>>(Constants.MultiSelectUsers, view.UserView, new UserService<UserModel>(roleService.OrgService));
            teamPresenter = new MultiSelectPresenter<RoleModel, TeamModel, TeamService<TeamModel>>(Constants.MultiSelectTeams, view.TeamView, new TeamService<TeamModel>(roleService.OrgService));
            userPresenter.FilerBySelecetedPrimaryEntityBU = true;
            teamPresenter.FilerBySelecetedPrimaryEntityBU = true;
        }

        private void SearchPrimaryEntityEvenHandler(object sender, EventArgs e)
        {
            nameSearchPhrase = this.view.NameSearchPhrase;
            string selectedBU = this.view.SelectedBusinessUnit;
            RunAsync("Loading Security Data...",
                () =>
                {
                    roles = roleService.InitialLoadAndCacheRelatedData(selectedBU, nameSearchPhrase);
                },
                () =>
                {
                    this.view.PrimaryEntityRecordSelection -= RoleSelectionEventHandler;
                    roleBindingSource.DataSource = IEnumerableToDataTable.ToDataTable<RoleModel>(roles);
                    this.view.RecordCount = roles.Count();
                    this.view.PrimaryEntityRecordSelection += RoleSelectionEventHandler;
                },
                (error) =>
                {
                    MessageBox.Show(error.Message);
                }
            );
        }
        private void RoleSelectionEventHandler(object sender, EventArgs e)
        {
            var selectedIds = view.GetSelectedPrimaryEntityIds();
            selectedRoles = roles.Where(a => selectedIds.Contains(a.Id)).ToList();
            userPresenter.SelectedPrimaryEntities = selectedRoles;
            teamPresenter.SelectedPrimaryEntities = selectedRoles;            
        }
    }
}
