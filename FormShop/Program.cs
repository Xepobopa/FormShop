using FormShop.Controller;
using FormShop.View;

namespace FromShop
{
    internal static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
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
            FormController.Add(new FailedForm());
            FormController.Add(new RegisterForm());
            FormController.Add(new PasswordResetForm());
            FormController.Add(new ShopForm());
            FormController.SetErrorForm(new FailedForm());
            Application.Run(FormController.GetFirst());
        }
    }
}