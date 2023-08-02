namespace PKM.XRM.SecurityManager.DataModelLayer
{
    public class UserTeamModel : BaseModel
    {
        public UserModel User { get; set; }
        public TeamModel Team { get; set; }
    }
}
