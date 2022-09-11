using Dapper.Contrib.Extensions;

namespace FormShop.Controller
{
    internal class UserInfoController
    {
        public UserInfoController()
        {
            var connection = DatabaseConnection.GetInstance(new ControllerJson().jsonModel).connection;
            _UserInfos = connection.GetAll<Model.UserInfo>().ToList();
        }
        public void Add(Model.UserInfo obj)
        {
            var connection = DatabaseConnection.GetInstance(new ControllerJson().jsonModel).connection;
            _UserInfos.Add(obj);
            connection.Insert<Model.UserInfo>(obj);
        }

        public ICollection<Model.UserInfo> GetList() => _UserInfos;

        public ICollection<Model.UserInfo> _UserInfos { get; set; }
    }
}
