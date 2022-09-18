namespace FormShop.View
{
    partial class PasswordResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetForm));
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTB
            // 
            resources.ApplyResources(this.LoginTB, "LoginTB");
            this.LoginTB.Name = "LoginTB";
            // 
            // ConfirmPasswordTB
            // 
            resources.ApplyResources(this.ConfirmPasswordTB, "ConfirmPasswordTB");
            this.ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            // 
            // PasswordTB
            // 
            resources.ApplyResources(this.PasswordTB, "PasswordTB");
            this.PasswordTB.Name = "PasswordTB";
            // 
            // ResetButton
            // 
            resources.ApplyResources(this.ResetButton, "ResetButton");
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PasswordResetForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.ConfirmPasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Name = "PasswordResetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LoginTB;
        private TextBox ConfirmPasswordTB;
        private TextBox PasswordTB;
        private Button ResetButton;
    }
}