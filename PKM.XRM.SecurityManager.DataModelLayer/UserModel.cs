namespace PKM.XRM.SecurityManager.DataModelLayer
{
    public class UserModel : BaseModel
    {
        public string DomainName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string PrimaryEmail { get; set; }

        public string AccessMode { get; set; }

        public string IsDisabled { get; set; }
    }
}
