namespace FormShop.View.ProductChangeData
{
    partial class ChangeDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Submit_button = new System.Windows.Forms.Button();
            this.id_comboBox = new System.Windows.Forms.ComboBox();
            this.price_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(12, 145);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(225, 23);
            this.Name_textBox.TabIndex = 5;
            // 
            // Submit_button
            // 
            this.Submit_button.Location = new System.Drawing.Point(12, 176);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(112, 23);
            this.Submit_button.TabIndex = 6;
            this.Submit_button.Text = "Submit";
            this.Submit_button.UseVisualStyleBackColor = true;
            this.Submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // id_comboBox
            // 
            this.id_comboBox.FormattingEnabled = true;
            this.id_comboBox.Location = new System.Drawing.Point(12, 27);
            this.id_comboBox.Name = "id_comboBox";
            this.id_comboBox.Size = new System.Drawing.Size(225, 23);
            this.id_comboBox.TabIndex = 7;
            // 
            // price_numericUpDown
            // 
            this.price_numericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.price_numericUpDown.Location = new System.Drawing.Point(12, 85);
            this.price_numericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.price_numericUpDown.Name = "price_numericUpDown";
            this.price_numericUpDown.Size = new System.Drawing.Size(225, 23);
            this.price_numericUpDown.TabIndex = 7;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(125, 176);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(112, 23);
            this.Delete_button.TabIndex = 8;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // ChangeDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 211);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.price_numericUpDown);
            this.Controls.Add(this.id_comboBox);
            this.Controls.Add(this.Submit_button);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeDataForm";
            this.Text = "ChangeDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.price_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Name_textBox;
        private Button Submit_button;
        private ComboBox id_comboBox;
        private NumericUpDown price_numericUpDown;
        private Button Delete_button;
    }
}