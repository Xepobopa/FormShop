using Dapper.Contrib.Extensions;

namespace FormShop.Model
{
    [Table("UserInfo")]
    public class UserInfo
    {
        public UserInfo() { }

        [Key]
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime PasswordChange { get; set; }
        public int PasswordChangeCount { get; set; }
    }
}
