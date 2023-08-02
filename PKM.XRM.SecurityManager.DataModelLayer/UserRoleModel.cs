namespace PKM.XRM.SecurityManager.DataModelLayer
{
    public class UserRoleModel : BaseModel 
    {
        public UserModel User { get; set; }
        public RoleModel Role { get; set; }
    }
}
