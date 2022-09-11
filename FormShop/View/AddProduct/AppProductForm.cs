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
using FormShop.Model;

namespace FormShop.View.AddProduct
{
    public partial class AppProductForm : Form
    {
        public AppProductForm()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            productController = new ProductController();
        }

        CategoryController categoryController;
        ProductController productController;

        private void Submit_button_Click(object sender, EventArgs e)
        {
            productController.Add(new Product(0, this.Name_textBox.Text,
                int.Parse(this.price_numericUpDown.Value.ToString()),
                categoryController._categories.Where(x => x.Name.Equals(this.id_comboBox.Text)).FirstOrDefault().Id));

            this.Close();
        }

        private void AppProductForm_Load(object sender, EventArgs e)
        {
            this.id_comboBox.Items.AddRange(categoryController._categories.Select(x => x.Name).ToArray());
        }
    }
}
