using FormShop.Model;
using Dapper.Contrib.Extensions;
using System.Linq;

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

        // delete by id
        public void Delete(Product obj)
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;
            //_products.Remove(_products.FirstOrDefault(x => x.Id.Equals(id)));
            connection.Delete(obj);
        }


        public List<Product> _products { private set; get; }
    }
}
