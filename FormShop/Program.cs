using FormShop.Controller;
using FormShop.View;
using FormShop.View.ProductChangeData;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormController.Add(new SignIn());
            FormController.Add(new ManagerForm());
            FormController.Add(new UserForm());
            FormController.Add(new FailedForm());
            FormController.Add(new RegisterForm());
            FormController.Add(new ShopForm());
            FormController.Add(new ChangeDataForm());
            FormController.SetErrorForm(new FailedForm());

            Application.Run(FormController.GetFirst());
        }
    }
}
           