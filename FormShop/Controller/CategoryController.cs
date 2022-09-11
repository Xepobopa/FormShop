using Dapper.Contrib.Extensions;
using FormShop.Model;


namespace FormShop.Controller
{
    public class CategoryController
    {
        public CategoryController()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            _categories = connection.GetAll<CategoryModel>().ToList();
        }

        public void Add(CategoryModel obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            _categories.Add(obj);
            connection.Insert<CategoryModel>(obj);
        }

        public ICollection<CategoryModel> GetList() => _categories;


        public ICollection<CategoryModel> _categories { get; private set; }
    }
}
