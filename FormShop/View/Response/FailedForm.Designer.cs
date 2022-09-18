namespace FormShop.View
{
    partial class FailedForm
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
            this.ErrorMessage_LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorMessage_LBL
            // 
            this.ErrorMessage_LBL.AutoSize = true;
            this.ErrorMessage_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage_LBL.Location = new System.Drawing.Point(94, 24);
            this.ErrorMessage_LBL.MaximumSize = new System.Drawing.Size(250, 0);
            this.ErrorMessage_LBL.Name = "ErrorMessage_LBL";
            this.ErrorMessage_LBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorMessage_LBL.Size = new System.Drawing.Size(101, 25);
            this.ErrorMessage_LBL.TabIndex = 0;
            this.ErrorMessage_LBL.Text = "дима гей";
            // 
            // FailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 186);
            this.Controls.Add(this.ErrorMessage_LBL);
            this.Name = "FailedForm";
            this.Text = "AuthFailedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ErrorMessage_LBL;
    }
}