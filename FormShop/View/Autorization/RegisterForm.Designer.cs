namespace FormShop.View
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Register_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Email_TB
            // 
            resources.ApplyResources(this.Email_TB, "Email_TB");
            this.Email_TB.Name = "Email_TB";
            // 
            // Password_TB
            // 
            resources.ApplyResources(this.Password_TB, "Password_TB");
            this.Password_TB.Name = "Password_TB";
            // 
            // Register_BTN
            // 
            resources.ApplyResources(this.Register_BTN, "Register_BTN");
            this.Register_BTN.Name = "Register_BTN";
            this.Register_BTN.UseVisualStyleBackColor = true;
            this.Register_BTN.Click += new System.EventHandler(this.Register_BTN_Click);
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Register_BTN);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Email_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Email_TB;
        private TextBox Password_TB;
        private Button Register_BTN;
    }
}