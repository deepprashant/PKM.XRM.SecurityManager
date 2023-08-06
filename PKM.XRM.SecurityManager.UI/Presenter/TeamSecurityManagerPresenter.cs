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
    public class TeamSecurityManagerPresenter : BasePresenter
    {
        private ITeamSecurityManagerView view;
        private TeamService<TeamModel> teamService;
        private ICRMEntityViewService entityViewService;
        private BindingSource teamEntityViewsBindingSource;
        private BindingSource teamBindingSource;
        private IEnumerable<TeamModel> teams;
        private IEnumerable<CRMEntityViewModel> entityViews;
        private string selectedUserViewFetchXML;
        private string userNameSearchPhrase;
        private List<TeamModel> selectedTeams;
        MultiSelectPresenter<TeamModel, RoleModel, RoleService<RoleModel>> rolePresenter;
        MultiSelectPresenter<TeamModel, UserModel, UserService<UserModel>> userPresenter;
        MultiSelectPresenter<TeamModel, FSPModel, FSPService<FSPModel>> fspPresenter;

        public TeamSecurityManagerPresenter(ITeamSecurityManagerView view, TeamService<TeamModel> teamService, ICRMEntityViewService entityViewService)
        {
            this.teamEntityViewsBindingSource = new BindingSource();
            this.teamBindingSource = new BindingSource();
            this.view = view;
            this.teamService = teamService;
            this.entityViewService = entityViewService;
            this.view.SearchPrimaryEntity += SearchPrimaryEntityEvenHandler;
            LoadTeamEntityViews();
            this.view.SetTeamEntityViewBindingSource(teamEntityViewsBindingSource);
            this.view.SetUsersBindingSource(teamBindingSource);
            InitialIzeControls();
            this.view.Show();
        }

        private void InitialIzeControls()
        {
            rolePresenter = new MultiSelectPresenter<TeamModel, RoleModel, RoleService<RoleModel>>(Constants.MultiSelectRoles, view.SecurityRoleView, new RoleService<RoleModel>(teamService.OrgService));
            userPresenter = new MultiSelectPresenter<TeamModel, UserModel, UserService<UserModel>>(Constants.MultiSelectUsers, view.UserView, new UserService<UserModel>(teamService.OrgService));
            fspPresenter = new MultiSelectPresenter<TeamModel, FSPModel, FSPService<FSPModel>>(Constants.MultiSelectFSPs, view.FieldSecurityProfileView, new FSPService<FSPModel>(teamService.OrgService));
            fspPresenter.HideBusinessUniteColumn();
            rolePresenter.FilerBySelecetedPrimaryEntityBU = true;
        }

        private void LoadTeamEntityViews()
        {
            entityViews = entityViewService.GetEntityViews("team", true);
            teamEntityViewsBindingSource.DataSource = entityViews;
        }
        private void SearchPrimaryEntityEvenHandler(object sender, EventArgs e)
        {
            selectedUserViewFetchXML = this.view.SelectedUserEntityViewFetchXML;
            userNameSearchPhrase = this.view.UserNameSearchPhrase;
            RunAsync("Loading Security Data...",
                () =>
                {
                    teams = teamService.InitialLoadAndCacheRelatedData(selectedUserViewFetchXML, userNameSearchPhrase);
                },
                () =>
                {
                    this.view.PrimaryEntityRecordSelection -= TeamSelectionEventHandler;
                    teamBindingSource.DataSource = IEnumerableToDataTable.ToDataTable<TeamModel>(teams);
                    this.view.UserCount = teams.Count();
                    this.view.PrimaryEntityRecordSelection += TeamSelectionEventHandler;
                },
                (error) =>
                {
                    MessageBox.Show(error.Message);
                }
            );
        }
        private void TeamSelectionEventHandler(object sender, EventArgs e)
        {
            var selectedTeamIds = view.GetSelectedTeamsId();
            selectedTeams = teams.Where(a => selectedTeamIds.Contains(a.Id)).ToList();
            rolePresenter.SelectedPrimaryEntities = selectedTeams;
            userPresenter.SelectedPrimaryEntities = selectedTeams;
            fspPresenter.SelectedPrimaryEntities = selectedTeams;
            var selectedUsersBUs = selectedTeams.Select(a => a.BusinessUnitId).Distinct();
            if (selectedTeams.Count() >= 1 && selectedUsersBUs.Count() == 1)
            {
            }
            else
            {
                MessageBox.Show("Please select useres from same Business Unnit to perform bulk operation");
            }
        }
    }
}
