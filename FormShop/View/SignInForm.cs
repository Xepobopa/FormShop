using FormShop.Controller;

namespace FormShop.View
{
    public partial class SignIn : Form
    {
        UserController userController = new UserController();

        public SignIn()
        {
            InitializeComponent();
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

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_BTN_Click(object sender, EventArgs e)
        {
            FormController.Start("RegisterForm");
            userController = new UserController(); // ???????? ??????????, ????? ?? ??????? ????? ??????
        }


        private void ResetPassword_Click(object sender, EventArgs e)
        {
            FormController.Start("PasswordResetForm");
        }
    }
}