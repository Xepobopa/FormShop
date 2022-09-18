namespace FormShop.View
{
    partial class UserForm
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
            this.Shop_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Orders_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Shop_Button
            // 
            this.Shop_Button.Location = new System.Drawing.Point(12, 12);
            this.Shop_Button.Name = "Shop_Button";
            this.Shop_Button.Size = new System.Drawing.Size(84, 23);
            this.Shop_Button.TabIndex = 0;
            this.Shop_Button.Text = "Магазин";
            this.Shop_Button.UseVisualStyleBackColor = true;
            this.Shop_Button.Click += new System.EventHandler(this.Shop_Button_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.Location = new System.Drawing.Point(12, 41);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(84, 23);
            this.Settings_Button.TabIndex = 1;
            this.Settings_Button.Text = "Настройки";
            this.Settings_Button.UseVisualStyleBackColor = true;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(102, 41);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(84, 23);
            this.Exit_Button.TabIndex = 2;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Orders_Button
            // 
            this.Orders_Button.Location = new System.Drawing.Point(102, 12);
            this.Orders_Button.Name = "Orders_Button";
            this.Orders_Button.Size = new System.Drawing.Size(84, 23);
            this.Orders_Button.TabIndex = 3;
            this.Orders_Button.Text = "Мои заказы";
            this.Orders_Button.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(193, 87);
            this.Controls.Add(this.Orders_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.Shop_Button);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Shop_Button;
        private Button Settings_Button;
        private Button Exit_Button;
        private Button Orders_Button;
    }
}