using Dapper.Contrib.Extensions;
using System.Data;

namespace FormShop.Controller
{
    internal class UserController
    {
        public IDbConnection Connection { get; set; }
        public UserController()
        {
            Connection = DatabaseConnection.GetInstance(new ControllerJson().jsonModel).connection;
            _Users = Connection.GetAll<Model.User>().ToList();
        }
        public void Add(Model.User obj)
        {
            UserInfoController userInfoController = new UserInfoController();
            Model.UserInfo user_info = new Model.UserInfo();
            userInfoController.Add(user_info);

            obj.UserInfoID = user_info.Id;

            var connection = DatabaseConnection.GetInstance(new ControllerJson().jsonModel).connection;
            _Users.Add(obj);
            connection.Insert<Model.User>(obj);
        }
        public void Change(Model.User newUser)
        {
           var res = _Users.First((x) => x.Email.Equals(newUser.Email));  
           if (res != null)
            {
                res.PasswordHash = newUser.PasswordHash;
                Connection.Update<Model.User>(res);
            } 
        }
        public bool Exists(Model.User user)
        {
            return _Users.Any(x => x.Equals(user));
        }
        public bool Exists(String email)
        {
            return _Users.Any(x => x.Email.Equals(email));
        }
        public Model.Role Authorize(Model.User user)
        {
            Model.User roleid = _Users.Where(x => x.Equals(user)).FirstOrDefault();
            if (roleid == null) return null;
            return new RoleController().GetList().ElementAt(roleid.RoleID - 1);
        }

        public ICollection<Model.User> GetList() => _Users;

        public ICollection<Model.User> _Users { get; set; }
    }
}
