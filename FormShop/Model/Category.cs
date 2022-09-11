using Dapper.Contrib.Extensions;

namespace FormShop.Model
{
    [Table("Category")]
    public class CategoryModel
    {
        public CategoryModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
