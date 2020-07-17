namespace bikeRent
{
    partial class ClientSettings
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
            this.clientPanel.SuspendLayout();
            this.AdminSigningroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailToolTip.SetToolTip(this.emailLabel, "example@example.com");
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(40, 385);
            this.signButton.Text = "Save";
            this.signButton.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // ClientSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ClientSettings";
            this.Text = "ClientSettings";
            this.Load += new System.EventHandler(this.ClientSettings_Load);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            this.AdminSigningroupBox.ResumeLayout(false);
            this.AdminSigningroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}