using FormShop.Controller;
using System.ComponentModel;
using System.Globalization;

namespace FormShop.View
{
    public partial class SignIn : Form
    {
        UserController userController = new UserController();

        public SignIn()
        {
            InitializeComponent();
            ChangeLanguage("uk");
        }

        private void SignIn_BTN_Click(object sender, EventArgs e)
        {
            Model.Role roleName = userController.Authorize(new Model.User()
            {
                Email = Login_TB.Text,
                PasswordHash = HashController.GenerateHash(Password_TB.Text)
            });

            FormController.Start(((roleName == null) ? FormController.GetErrorForm().Name : $"{roleName.RoleName}Form"));

        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(SignIn));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_BTN_Click(object sender, EventArgs e)
        {
            FormController.Start("RegisterForm");
            userController = new UserController(); // релоадим контроллер, чтобы он получил новые данные
        }

        private void change_lang_button_Click(object sender, EventArgs e)
        {
            ChangeLanguage((sender as Button).Name.Split('_')[0]);
        }
    }
}