namespace RINGAWEB.Entities.Account
{
    public class Account
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int StatusId { get; set; }
        public int RoleId { get; set; }
        public string Address { get; set; }
        public int StarPoint { get; set; }
        
    }
}
