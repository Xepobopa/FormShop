using FormShop.Controller;
using FormShop;

namespace FormShop.View
{
    public partial class RegisterForm : Form
    {
        UserInfoController userInfoController = new UserInfoController();
        UserController userController = new UserController();
        PasswordController passwordController = new PasswordController();
        EmailController emailController = new EmailController();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void Register_BTN_Click(object sender, EventArgs e)
        {
            // TestPassword12345__
            // Гора разных проверок

            if (!emailController.IsValid(Email_TB.Text))
            {
                Email_TB.BackColor = Color.Red;
                return;
            }

            if (!passwordController.IsValid(Password_TB.Text)) 
            {
                Password_TB.BackColor = Color.Red;
                return;
            };

            if (userController.GetList().Any(x => x.Email.Equals(Email_TB.Text))) 
            { 
                FormController.GetErrorForm().ShowDialog();
                return;
            };

            // Генерирую хэш один раз, что-бы не генерировать его при каждом проходе цикла ниже,
            // так как это уничтожит производительность
            
            userController.Add(new Model.User() {
                Email = Email_TB.Text,
                PasswordHash = HashController.GenerateHash(Password_TB.Text),
                RoleID = 2
            });

            Close();
        }
    }
}
