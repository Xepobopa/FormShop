using FormShop.View;
using FormShop.Controller;

namespace FormShop.View
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void GoToShop_button_Click(object sender, EventArgs e)
        {
            FormController.Start("ShopForm");
        }
    }
}
