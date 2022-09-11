namespace FormShop.View
{
    partial class ShopForm : Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.button_ResetFilters = new System.Windows.Forms.Button();
            this.FindProduct_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_radioButton = new System.Windows.Forms.RadioButton();
            this.Price_radioButton = new System.Windows.Forms.RadioButton();
            this.Name_RadioButton = new System.Windows.Forms.RadioButton();
            this.Update_button = new System.Windows.Forms.Button();
            this.AddProduct_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(205, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 659);
            this.panel1.TabIndex = 0;
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 15;
            this.CategoryListBox.Location = new System.Drawing.Point(12, 10);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(188, 334);
            this.CategoryListBox.TabIndex = 1;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // button_ResetFilters
            // 
            this.button_ResetFilters.Location = new System.Drawing.Point(13, 348);
            this.button_ResetFilters.Name = "button_ResetFilters";
            this.button_ResetFilters.Size = new System.Drawing.Size(187, 23);
            this.button_ResetFilters.TabIndex = 2;
            this.button_ResetFilters.Text = "Сбросить фильтр";
            this.button_ResetFilters.UseVisualStyleBackColor = true;
            this.button_ResetFilters.Click += new System.EventHandler(this.button_ResetFilters_Click);
            // 
            // FindProduct_textBox
            // 
            this.FindProduct_textBox.Location = new System.Drawing.Point(12, 646);
            this.FindProduct_textBox.Name = "FindProduct_textBox";
            this.FindProduct_textBox.PlaceholderText = "Search Product...";
            this.FindProduct_textBox.Size = new System.Drawing.Size(188, 23);
            this.FindProduct_textBox.TabIndex = 3;
            this.FindProduct_textBox.TextChanged += new System.EventHandler(this.FindProduct_textBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Id_radioButton);
            this.panel2.Controls.Add(this.Price_radioButton);
            this.panel2.Controls.Add(this.Name_RadioButton);
            this.panel2.Location = new System.Drawing.Point(12, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 100);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by:";
            // 
            // Id_radioButton
            // 
            this.Id_radioButton.AutoSize = true;
            this.Id_radioButton.Location = new System.Drawing.Point(6, 28);
            this.Id_radioButton.Name = "Id_radioButton";
            this.Id_radioButton.Size = new System.Drawing.Size(35, 19);
            this.Id_radioButton.TabIndex = 2;
            this.Id_radioButton.TabStop = true;
            this.Id_radioButton.Text = "Id";
            this.Id_radioButton.UseVisualStyleBackColor = true;
            this.Id_radioButton.CheckedChanged += new System.EventHandler(this.Id_radioButton_CheckedChanged);
            // 
            // Price_radioButton
            // 
            this.Price_radioButton.AutoSize = true;
            this.Price_radioButton.Location = new System.Drawing.Point(6, 53);
            this.Price_radioButton.Name = "Price_radioButton";
            this.Price_radioButton.Size = new System.Drawing.Size(51, 19);
            this.Price_radioButton.TabIndex = 1;
            this.Price_radioButton.TabStop = true;
            this.Price_radioButton.Text = "Price";
            this.Price_radioButton.UseVisualStyleBackColor = true;
            this.Price_radioButton.CheckedChanged += new System.EventHandler(this.Price_radioButton_CheckedChanged);
            // 
            // Name_RadioButton
            // 
            this.Name_RadioButton.AutoSize = true;
            this.Name_RadioButton.Location = new System.Drawing.Point(6, 78);
            this.Name_RadioButton.Name = "Name_RadioButton";
            this.Name_RadioButton.Size = new System.Drawing.Size(57, 19);
            this.Name_RadioButton.TabIndex = 0;
            this.Name_RadioButton.TabStop = true;
            this.Name_RadioButton.Text = "Name";
            this.Name_RadioButton.UseVisualStyleBackColor = true;
            this.Name_RadioButton.CheckedChanged += new System.EventHandler(this.Name_RadioButton_CheckedChanged);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(12, 377);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(187, 23);
            this.Update_button.TabIndex = 5;
            this.Update_button.Text = "Обновить товары";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // AddProduct_button
            // 
            this.AddProduct_button.Location = new System.Drawing.Point(12, 406);
            this.AddProduct_button.Name = "AddProduct_button";
            this.AddProduct_button.Size = new System.Drawing.Size(187, 23);
            this.AddProduct_button.TabIndex = 6;
            this.AddProduct_button.Text = "Добавить товар";
            this.AddProduct_button.UseVisualStyleBackColor = true;
            this.AddProduct_button.Click += new System.EventHandler(this.AddProduct_button_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 678);
            this.Controls.Add(this.AddProduct_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FindProduct_textBox);
            this.Controls.Add(this.button_ResetFilters);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShopForm";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ListBox CategoryListBox;
        private Button button_ResetFilters;
        private TextBox FindProduct_textBox;
        private Panel panel2;
        private RadioButton Id_radioButton;
        private RadioButton Price_radioButton;
        private RadioButton Name_RadioButton;
        private Label label1;
        private Button Update_button;
        private Button AddProduct_button;
    }
}

