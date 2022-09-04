using Dapper.Contrib.Extensions;

namespace FormShop.Model
{
    [Table("Role")]
    public class Role
    {
        public Role() { }

        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
