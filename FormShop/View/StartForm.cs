using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using FormShop.Model;
using WindowsFormsApp1.View.CustomControls;
using FormShop.Controller;
using FormShop.View.AddProduct;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class StartForm : Form
    {
        ProductController product_controller;
        CategoryController category_controller;

        public StartForm()
        {
            InitializeComponent();
            product_controller = new ProductController();
            category_controller = new CategoryController();


            CategoryListBox.Items.AddRange(category_controller._categories.Select(x => x.Name).ToArray());

            AddProductsToList(product_controller._products);
        }

        private void AddProductsToList(List<Product> list)
        {
            panel1.Controls.Clear();
            int x = 0, y = 10;
            for (int i = 0; i < list.Count; i++)
            {
                ProductControl tmp = new ProductControl(list[i]);
                if (i % 5 == 0)
                {
                    y += tmp.Height + 10;
                    x = 0;
                }
                tmp.Location = new Point(x, y);
                panel1.Controls.Add(tmp);
                x += tmp.Width + 10;

            }
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryListBox.SelectedItem != null)
            {
                int curr_category_id = category_controller._categories.Where(x => x.Name.Equals(CategoryListBox.SelectedItem)).FirstOrDefault().Id;

                AddProductsToList(product_controller._products.Where(x => x.Category_key.Equals(curr_category_id)).ToList());
            }
        }

        private void button_ResetFilters_Click(object sender, EventArgs e)
        {
            AddProductsToList(product_controller._products);
        }

        private void FindProduct_textBox_TextChanged(object sender, EventArgs e)
        {
            AddProductsToList(product_controller._products.Where(x => x.Name.ToLower().Contains(FindProduct_textBox.Text.ToLower())).ToList());
        }

        private void Id_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            AddProductsToList(product_controller._products.OrderBy(x => x.Id).ToList());
        }

        private void Price_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            AddProductsToList(product_controller._products.OrderBy(x => x.Price).ToList());
        }

        private void Name_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AddProductsToList(product_controller._products.OrderBy(x => x.Name).ToList());
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            product_controller = new ProductController();
            AddProductsToList(product_controller._products);   
        }

        private void AddProduct_button_Click(object sender, EventArgs e)
        {
            AppProductForm addForm = new AppProductForm();
            addForm.Show();
        }
    }
}
