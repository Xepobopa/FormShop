namespace FormShop.View.Response
{
    partial class SuccessForm
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
            this.Success_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Success_label
            // 
            this.Success_label.AutoSize = true;
            this.Success_label.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Success_label.Location = new System.Drawing.Point(172, 150);
            this.Success_label.Name = "Success_label";
            this.Success_label.Size = new System.Drawing.Size(453, 128);
            this.Success_label.TabIndex = 0;
            this.Success_label.Text = "SUCCESS";
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Success_label);
            this.Name = "SuccessForm";
            this.Text = "SuccessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Success_label;
    }
}