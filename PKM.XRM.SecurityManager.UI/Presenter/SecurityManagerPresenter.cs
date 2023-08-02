using PKM.XRM.SecurityManager.Common;
using PKM.XRM.SecurityManager.DataModelLayer;
using PKM.XRM.SecurityManager.ServiceLayer;
using PKM.XRM.SecurityManager.UI.CustomEventArgs;
using PKM.XRM.SecurityManager.UI.View;
using System;

namespace PKM.XRM.SecurityManager.UI.Presenter
{
    public class SecurityManagerPresenter : BasePresenter
    {
        private ISecurityManagerView view;
        private ISecurityManagerService service;
        private Action closeControl;
        private string currentDisplayedView;
        private BasePresenter childPresenter;

        public SecurityManagerPresenter(ISecurityManagerView view, SecurityManagerService service, Action closeControl)
        {
            this.view = view;
            this.service = service;
            this.closeControl = closeControl;
            this.view.NavigationEvent += HandleNavigationEvent;
            LoadInitialData();
        }

        private void HandleNavigationEvent(object sender, EventArgs e)
        {
            SecurityManagerEventArgs args = (SecurityManagerEventArgs)e;
            if (args.DisaplayView != currentDisplayedView)
            {
                currentDisplayedView = args.DisaplayView;
                LoadControlInBody();
            }
        }

        private void LoadControlInBody()
        {
            switch (currentDisplayedView)
            {
                case Constants.UserSecurityManagerView:
                    var userSecurityManagerView = new UserSecurityManagerView();
                    childPresenter = new UserSecurityManagerPresenter(userSecurityManagerView, new UserService<UserModel>(service.CrmService), new CRMEntityViewService(service.CrmService));
                    view.ClearAndDisplayControlInBodyPanel(userSecurityManagerView);
                    break;
                case Constants.TeamSecurityManagerView:
                    var teamSecurityManagerView = new TeamSecurityManagerView();
                    childPresenter = new TeamSecurityManagerPresenter(teamSecurityManagerView, new TeamService<TeamModel>(service.CrmService), new CRMEntityViewService(service.CrmService));
                    view.ClearAndDisplayControlInBodyPanel(teamSecurityManagerView);
                    break;
                case Constants.FieldSecurityProfileManagerView:
                    var fieldSecurityManagerView = new FieldSecurityManagerView();
                    childPresenter = new FieldSecurityManagerPresenter(fieldSecurityManagerView, new FSPService<FSPModel>(service.CrmService));
                    view.ClearAndDisplayControlInBodyPanel(fieldSecurityManagerView);
                    break;
                case Constants.SecurityRoleManagerView:
                    var securityRoleManagerView = new SecurityRoleManagerView();
                    childPresenter = new SecurityRoleManagerPresenter(securityRoleManagerView, new RoleService<RoleModel>(service.CrmService));
                    view.ClearAndDisplayControlInBodyPanel(securityRoleManagerView);
                    break;
                case Constants.CloseTool:
                    closeControl();
                    break;
            }
        }

        public void ConnectionChanged(SecurityManagerService service)
        {
            this.service = service;
            LoadControlInBody();
        }

        private void LoadInitialData()
        {

            RunAsync("Loading Security Data...",
               () =>
               {
                   service.InitialDataLoad();
               },
               () =>
               {

               },
               (error) =>
               {
                   ShowErrorMessage(error);
               }
           );
        }
    }
}
