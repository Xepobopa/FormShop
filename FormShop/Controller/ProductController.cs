using FormShop.Model;
using Dapper.Contrib.Extensions;


namespace FormShop.Controller
{
    internal class ProductController
    {
        public ProductController()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            _products = connection.GetAll<Product>() as List<Product>;
        }

        public void Add(Product obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            _products.Add(obj);
            connection.Insert<Product>(obj);
        }


        public List<Product> _products { private set; get; }
    }
}
