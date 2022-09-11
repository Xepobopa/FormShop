using Dapper.Contrib.Extensions;

namespace FormShop.Model
{
    [Table("[User]")]
    public class User
    {
        public User() { }

        [Key]
        public int Id { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public int UserInfoID { get; set; }
        public int RoleID { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is User)
            {
                User user = obj as User;

                if (PasswordHash.Equals(user.PasswordHash) && Email.Equals(user.Email))
                    return true;
                
            }

            return false;
        }
    }
}
