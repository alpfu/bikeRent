namespace bikeRent
{
    partial class choosingAccountType
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choosingAccountType));
            this.ClientSignradioButton = new System.Windows.Forms.RadioButton();
            this.AdminSignradioButton = new System.Windows.Forms.RadioButton();
            this.AdmintoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ClientSignradioButton
            // 
            this.ClientSignradioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ClientSignradioButton.AutoSize = true;
            this.ClientSignradioButton.Location = new System.Drawing.Point(31, 49);
            this.ClientSignradioButton.Name = "ClientSignradioButton";
            this.ClientSignradioButton.Size = new System.Drawing.Size(99, 17);
            this.ClientSignradioButton.TabIndex = 0;
            this.ClientSignradioButton.Text = "Sign in as client";
            this.ClientSignradioButton.UseVisualStyleBackColor = true;
            this.ClientSignradioButton.CheckedChanged += new System.EventHandler(this.clientSigninChanged);
            // 
            // AdminSignradioButton
            // 
            this.AdminSignradioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AdminSignradioButton.AutoSize = true;
            this.AdminSignradioButton.Location = new System.Drawing.Point(31, 83);
            this.AdminSignradioButton.Name = "AdminSignradioButton";
            this.AdminSignradioButton.Size = new System.Drawing.Size(102, 17);
            this.AdminSignradioButton.TabIndex = 1;
            this.AdminSignradioButton.Text = "Sign in as admin";
            this.AdminSignradioButton.UseVisualStyleBackColor = true;
            this.AdminSignradioButton.CheckedChanged += new System.EventHandler(this.adminSigninChanged);
            // 
            // choosingAccountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(323, 204);
            this.Controls.Add(this.AdminSignradioButton);
            this.Controls.Add(this.ClientSignradioButton);
            this.Name = "choosingAccountType";
            this.Text = "Choose user type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ClientSignradioButton;
        private System.Windows.Forms.RadioButton AdminSignradioButton;
        private System.Windows.Forms.ToolTip AdmintoolTip;
    }
}