using FormShop.Model;
using FormShop.View.ProductChangeData;

namespace WindowsFormsApp1.View.CustomControls
{
    public partial class ProductControl : UserControl
    {
        bool isSelect = false;
        Product? product;
        public ProductControl()
        {
            InitializeComponent();
        }

        public ProductControl(Product product) : this()
        {
            this.product = product;
            idLabel.Text = product.Id.ToString();
            priceLabel.Text = $"{product.Price.ToString()} $";
            nameLabel.Text = product.Name.ToString();
        }

        private void ProductControl_Click(object sender, EventArgs e)
        {
            this.BackColor = (isSelect == false) ? Color.Red : Color.DarkSalmon;
            if (isSelect == false)
                Size = new Size(Size.Width, Size.Height - 10);
            else
                Size = new Size(Size.Width, Size.Height + 10);

            isSelect = !isSelect;

            changeProductData();
        }

        private void changeProductData()
        {
            ChangeDataForm changeForm = new ChangeDataForm();
            changeForm.ChangeDataForm_Load(product);
            changeForm.Show();
            
        }
    }
}
