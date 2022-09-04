using FormShop.Controller;
using FormShop.Model;
using FormShop.View;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var connection = new DatabaseConnection(new ControllerJson().jsonModel).connection;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormController.Add(new SignIn());
            FormController.Add(new ManagerForm());
            FormController.Add(new UserForm());
            FormController.Add(new AuthFailedForm());
            FormController.SetErrorForm(new AuthFailedForm());

            Application.Run(FormController.GetFirst());
        }
    }
}