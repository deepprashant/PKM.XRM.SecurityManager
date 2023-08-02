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
    public class FieldSecurityManagerPresenter : BasePresenter
    {
        private IFieldSecurityManagerView view;
        private FSPService<FSPModel> fspService;
        private BindingSource fieldSeurityBindingSource;
        private IEnumerable<FSPModel> fieldSecurities;
        //private IEnumerable<UserModel> users;
        private string nameSearchPhrase;
        private List<FSPModel> selectedFieldSecurities;
 
        MultiSelectPresenter<FSPModel, UserModel, UserService<UserModel>> userPresenter;
        MultiSelectPresenter<FSPModel, TeamModel, TeamService<TeamModel>> teamPresenter;

        public FieldSecurityManagerPresenter(IFieldSecurityManagerView view, FSPService<FSPModel> fspService)
        {
            this.fieldSeurityBindingSource = new BindingSource();
            this.view = view;
            this.fspService = fspService;
            this.view.SearchPrimaryEntity += SearchPrimaryEntityEvenHandler;
            this.view.SetFeidlSecuritiesBindingSource(fieldSeurityBindingSource);
            InitialIzeControls();
            //this.view.Show();
        }

        private void InitialIzeControls()
        {
            userPresenter = new MultiSelectPresenter<FSPModel, UserModel, UserService<UserModel>>(Constants.MultiSelectUsers, view.UserView, new UserService<UserModel>(fspService.OrgService));
            teamPresenter = new MultiSelectPresenter<FSPModel, TeamModel, TeamService<TeamModel>>(Constants.MultiSelectTeams, view.TeamView, new TeamService<TeamModel>(fspService.OrgService));
        }

        private void SearchPrimaryEntityEvenHandler(object sender, EventArgs e)
        {
            nameSearchPhrase = this.view.NameSearchPhrase;
            RunAsync("Loading Security Data...",
                () =>
                {
                    fieldSecurities = fspService.InitialLoadAndCacheRelatedData(string.Empty, nameSearchPhrase);
                },
                () =>
                {
                    this.view.PrimaryEntityRecordSelection -= FieldSecuritySelectionEventHandler;
                    fieldSeurityBindingSource.DataSource = IEnumerableToDataTable.ToDataTable<FSPModel>(fieldSecurities);
                    this.view.RecordCount = fieldSecurities.Count();
                    this.view.PrimaryEntityRecordSelection += FieldSecuritySelectionEventHandler;
                },
                (error) =>
                {
                    MessageBox.Show(error.Message);
                }
            );
        }
        private void FieldSecuritySelectionEventHandler(object sender, EventArgs e)
        {
            var selectedIds = view.GetSelectedPrimaryEntityIds();
            selectedFieldSecurities = fieldSecurities.Where(a => selectedIds.Contains(a.Id)).ToList();
            userPresenter.SelectedPrimaryEntities = selectedFieldSecurities;
            teamPresenter.SelectedPrimaryEntities = selectedFieldSecurities;            
        }
    }
}
