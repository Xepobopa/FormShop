using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormShop.Model;
using FormShop.Controller;

namespace FormShop.View.ProductChangeData
{
    public partial class ChangeDataForm : Form
    {
        public ChangeDataForm()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            productController = new ProductController();
        }

        CategoryController categoryController;
        ProductController productController;

        // custom loader that we have to call ourself
        public void ChangeDataForm_Load(Product product)
        {
            this.id_comboBox.Items.AddRange(categoryController._categories.Select(x => x.Name).ToArray());
            this.id_comboBox.SelectedIndex = product.Category_key - 1;

            this.price_numericUpDown.Value = product.Price;

            this.Name_textBox.Text = product.Name;
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            productController.Add(new Product(0, this.Name_textBox.Text, 
                int.Parse(this.price_numericUpDown.Value.ToString()), 
                categoryController._categories.Where(x => x.Name.Equals(this.id_comboBox.Text)).FirstOrDefault().Id));

            this.Close();
        }
    }
}
