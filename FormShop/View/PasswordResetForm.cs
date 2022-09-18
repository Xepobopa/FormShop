using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormShop.Controller;
using FormShop.Controller.ValidationAttribs;
using FormShop.Model;

namespace FormShop.View
{
    public partial class PasswordResetForm : Form
    {
        public PasswordResetForm()
        {
            InitializeComponent();
        }
        PasswordValidator validator = new PasswordValidator();
        UserController userController = new UserController();
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (!this.PasswordTB.Text.Equals(this.ConfirmPasswordTB.Text))
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (!validator.IsValid(PasswordTB.Text) || !userController.Exists(this.LoginTB.Text)) {
                MessageBox.Show("Пользователь не найден или ненадёжный пароль!");
            }
            else 
            {
                userController.Change(new User() {Email=this.LoginTB.Text,PasswordHash=(HashController.GenerateHash(this.PasswordTB.Text)) });
            }
        }
    }
}
