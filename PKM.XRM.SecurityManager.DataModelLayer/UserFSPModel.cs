namespace PKM.XRM.SecurityManager.DataModelLayer
{
    public class UserFSPModel : BaseModel
    {
        public UserModel User { get; set; }
        public FSPModel FSP { get; set; }
    }
}
