namespace FormShop.View
{
    partial class SignIn : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.SignIn_BTN = new System.Windows.Forms.Button();
            this.Register_BTN = new System.Windows.Forms.Button();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.ua_button = new System.Windows.Forms.Button();
            this.ru_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_TB
            // 
            resources.ApplyResources(this.Login_TB, "Login_TB");
            this.Login_TB.Name = "Login_TB";
            // 
            // Password_TB
            // 
            resources.ApplyResources(this.Password_TB, "Password_TB");
            this.Password_TB.Name = "Password_TB";
            // 
            // SignIn_BTN
            // 
            resources.ApplyResources(this.SignIn_BTN, "SignIn_BTN");
            this.SignIn_BTN.Name = "SignIn_BTN";
            this.SignIn_BTN.UseVisualStyleBackColor = true;
            this.SignIn_BTN.Click += new System.EventHandler(this.SignIn_BTN_Click);
            // 
            // Register_BTN
            // 
            resources.ApplyResources(this.Register_BTN, "Register_BTN");
            this.Register_BTN.Name = "Register_BTN";
            this.Register_BTN.UseVisualStyleBackColor = true;
            this.Register_BTN.Click += new System.EventHandler(this.Register_BTN_Click);
            // 
            // Exit_BTN
            // 
            resources.ApplyResources(this.Exit_BTN, "Exit_BTN");
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // ua_button
            // 
            this.ua_button.BackgroundImage = global::FormShop.Properties.Resources.rus;
            resources.ApplyResources(this.ua_button, "ua_button");
            this.ua_button.Name = "ua_button";
            this.ua_button.UseVisualStyleBackColor = true;
            this.ua_button.Click += new System.EventHandler(this.change_lang_button_Click);
            // 
            // ru_button
            // 
            this.ru_button.BackgroundImage = global::FormShop.Properties.Resources.Ua;
            resources.ApplyResources(this.ru_button, "ru_button");
            this.ru_button.Name = "ru_button";
            this.ru_button.UseVisualStyleBackColor = true;
            this.ru_button.Click += new System.EventHandler(this.change_lang_button_Click);
            // 
            // SignIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ru_button);
            this.Controls.Add(this.ua_button);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Register_BTN);
            this.Controls.Add(this.SignIn_BTN);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Login_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Login_TB;
        private TextBox Password_TB;
        private Button SignIn_BTN;
        private Button Register_BTN;
        private Button Exit_BTN;
        private Button ua_button;
        private Button ru_button;
    }
}