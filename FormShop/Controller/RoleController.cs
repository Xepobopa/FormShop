using Dapper.Contrib.Extensions;

namespace FormShop.Controller
{
    internal class RoleController
    {
        public RoleController()
        {
            var connection = DatabaseConnection.GetInstance(new ControllerJson().jsonModel).connection;
            _Roles = connection.GetAll<Model.Role>().ToList();
        }
        public void Add(Model.Role obj)
        {
            var connection = DatabaseConnection.GetInstance(new ControllerJson().jsonModel).connection;
            _Roles.Add(obj);
            connection.Insert<Model.Role>(obj);
        }
        
        public ICollection<Model.Role> GetList() => _Roles;

        public ICollection<Model.Role> _Roles { get; set; }

    }
}
