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
    public class UserSecurityManagerPresenter : BasePresenter
    {
        private IUserSecurityManagerView view;
        private UserService<UserModel> userService;
        private ICRMEntityViewService entityViewService;
        private BindingSource userEntityViewsBindingSource;
        private BindingSource usersBindingSource;
        private BindingSource userDirectAndTeamRolesBindingSource;
        private BindingSource userDirectAndTeamFSPsBindingSource;
        private IEnumerable<UserModel> users;
        private IEnumerable<CRMEntityViewModel> entityViews;
        private string selectedUserViewFetchXML;
        private string userNameSearchPhrase;
        private List<UserModel> selectedUsers;
        MultiSelectPresenter<UserModel, RoleModel, RoleService<RoleModel>> rolePresenter;
        MultiSelectPresenter<UserModel, TeamModel, TeamService<TeamModel>> teamPresenter;
        MultiSelectPresenter<UserModel, FSPModel, FSPService<FSPModel>> fspPresenter;
        private Guid selectedSingleUser;

        public UserSecurityManagerPresenter(IUserSecurityManagerView view, UserService<UserModel> userService, ICRMEntityViewService entityViewService)
        {
            this.userEntityViewsBindingSource = new BindingSource();
            this.usersBindingSource = new BindingSource();
            this.userDirectAndTeamRolesBindingSource = new BindingSource();
            this.userDirectAndTeamFSPsBindingSource = new BindingSource();
            this.view = view;
            this.userService = userService;
            this.entityViewService = entityViewService;
            this.view.SearchUser += SearchUserEvenHandler;
            LoadUserEntityViews();
            this.view.SetUserEntityViewBindingSource(userEntityViewsBindingSource);
            this.view.SetUsersBindingSource(usersBindingSource);
            this.view.SetUserDirectAndTeamRolesBindingSource(userDirectAndTeamRolesBindingSource);
            this.view.SetUserDirectAndTeamFSPsBindingSource(userDirectAndTeamFSPsBindingSource);
            InitialIzeControls();
            this.view.Show();
        }

        private void InitialIzeControls()
        {
            rolePresenter = new MultiSelectPresenter<UserModel, RoleModel, RoleService<RoleModel>>(Constants.MultiSelectRoles, view.SecurityRoleView, new RoleService<RoleModel>(userService.OrgService));
            teamPresenter = new MultiSelectPresenter<UserModel, TeamModel, TeamService<TeamModel>>(Constants.MultiSelectTeams, view.TeamView, new TeamService<TeamModel>(userService.OrgService));
            fspPresenter = new MultiSelectPresenter<UserModel, FSPModel, FSPService<FSPModel>>(Constants.MultiSelectFSPs, view.FieldSecurityProfileView, new FSPService<FSPModel>(userService.OrgService));
            fspPresenter.HideBusinessUniteColumn();

            rolePresenter.AssignmentChanged += RoleAssignmentChanged;
            teamPresenter.AssignmentChanged += TeamAssignmentChanged;
            fspPresenter.AssignmentChanged += FSPAssignmentChanged;

            //rolePresenter.Emp = "No records found.";
        }
        private void LoadUserEntityViews()
        {
            entityViews = entityViewService.GetEntityViews("systemuser", true);
            userEntityViewsBindingSource.DataSource = entityViews;
        }
        private void SearchUserEvenHandler(object sender, EventArgs e)
        {
            selectedUserViewFetchXML = this.view.SelectedUserEntityViewFetchXML;
            userNameSearchPhrase = this.view.UserNameSearchPhrase;
            RunAsync("Loading Security Data...",
                () =>
                {
                    users = userService.InitialLoadAndCacheRelatedData(selectedUserViewFetchXML, userNameSearchPhrase);
                },
                () =>
                {
                    this.view.UserSelection -= UserSelectionEventHandler;
                    usersBindingSource.DataSource = IEnumerableToDataTable.ToDataTable<UserModel>(users);
                    this.view.UserCount = users.Count();
                    this.view.UserSelection += UserSelectionEventHandler;
                },
                (error) =>
                {
                    MessageBox.Show(error.Message);
                }
            );
        }
        private void UserSelectionEventHandler(object sender, EventArgs e)
        {
            var selectedUserIds = view.GetSelectedUseresId();
            selectedUsers = users.Where(a => selectedUserIds.Contains(a.Id)).ToList();
            teamPresenter.SelectedPrimaryEntities = selectedUsers;
            fspPresenter.SelectedPrimaryEntities = selectedUsers;
            var selectedUsersBUs = selectedUsers.Select(a => a.BusinessUnitId).Distinct();
            var selecteduserCount = selectedUserIds.Count();
            if (selectedUsersBUs.Count() <= 1)
            {
                rolePresenter.SelectedPrimaryEntities = selectedUsers;
            }
            else
            {
                //MessageBox.Show("To bulk assign security roles, select useres from same BU");
                rolePresenter.SelectedPrimaryEntities = null;
            }

            if (selecteduserCount == 1)
            {
                selectedSingleUser = selectedUserIds.First();
                DisplayUserDirectAndTeamRoles(selectedSingleUser);
                DisplayUserDirectAndTeamFSPs(selectedSingleUser);
            }
            else
            {
                selectedSingleUser = Guid.Empty;
                userDirectAndTeamRolesBindingSource.DataSource = null;
                userDirectAndTeamFSPsBindingSource.DataSource = null;
                view.DirectAndTeamRoleCount = 0;
                view.DirectAndTeamFSPCount = 0;
            }
        }
        private void RoleAssignmentChanged(object sender, EventArgs e)
        {
            if (selectedSingleUser != Guid.Empty)
            {
                DisplayUserDirectAndTeamRoles(selectedSingleUser);
            }
        }
        private void TeamAssignmentChanged(object sender, EventArgs e)
        {
            if (selectedSingleUser != Guid.Empty)
            {
                DisplayUserDirectAndTeamRoles(selectedSingleUser);
                DisplayUserDirectAndTeamFSPs(selectedSingleUser);
            }
        }
        private void FSPAssignmentChanged(object sender, EventArgs e)
        {
            if (selectedSingleUser != Guid.Empty)
            {
                DisplayUserDirectAndTeamFSPs(selectedSingleUser);
            }
        }
        private void DisplayUserDirectAndTeamRoles(Guid userId)
        {
            var allRoles = userService.GetUserDirectAndTeamRoles(userId);
            userDirectAndTeamRolesBindingSource.DataSource = IEnumerableToDataTable.ToDataTable(allRoles);
            view.DirectAndTeamRoleCount = allRoles.Count();
        }
        private void DisplayUserDirectAndTeamFSPs(Guid userId)
        {
             var allFSPs = userService.GetUserDirectAndTeamFieldSecurityProfiles(userId);
            userDirectAndTeamFSPsBindingSource.DataSource = IEnumerableToDataTable.ToDataTable(allFSPs);
            view.DirectAndTeamFSPCount = allFSPs.Count();
        }
    }
}
