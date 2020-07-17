namespace bikeRent
{
    partial class ClientSignin
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
            this.clientPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AdminSigningroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.importantLabel = new System.Windows.Forms.Label();
            this.usernamatextBox = new System.Windows.Forms.TextBox();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.termRadioButton = new System.Windows.Forms.RadioButton();
            this.clientPanel.SuspendLayout();
            this.AdminSigningroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.BackColor = System.Drawing.Color.Transparent;
            this.clientPanel.Controls.Add(this.label2);
            this.clientPanel.Controls.Add(this.emailLabel);
            this.clientPanel.Controls.Add(this.phoneTextBox);
            this.clientPanel.Controls.Add(this.emailTextBox);
            this.clientPanel.Location = new System.Drawing.Point(295, 12);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(200, 240);
            this.clientPanel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.DarkGray;
            this.emailLabel.Location = new System.Drawing.Point(16, 13);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail";
            this.emailToolTip.SetToolTip(this.emailLabel, "example@example.com");
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(16, 105);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(178, 20);
            this.phoneTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(13, 38);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(184, 20);
            this.emailTextBox.TabIndex = 0;
            // 
            // emailToolTip
            // 
            this.emailToolTip.ShowAlways = true;
            // 
            // AdminSigningroupBox
            // 
            this.AdminSigningroupBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminSigningroupBox.Controls.Add(this.termRadioButton);
            this.AdminSigningroupBox.Controls.Add(this.linkLabel1);
            this.AdminSigningroupBox.Controls.Add(this.label5);
            this.AdminSigningroupBox.Controls.Add(this.label4);
            this.AdminSigningroupBox.Controls.Add(this.label3);
            this.AdminSigningroupBox.Controls.Add(this.passwordTextBox);
            this.AdminSigningroupBox.Controls.Add(this.LastNameTextBox);
            this.AdminSigningroupBox.Controls.Add(this.FirstNametextBox);
            this.AdminSigningroupBox.Controls.Add(this.usernamatextBox);
            this.AdminSigningroupBox.Controls.Add(this.importantLabel);
            this.AdminSigningroupBox.Controls.Add(this.label1);
            this.AdminSigningroupBox.Location = new System.Drawing.Point(24, 12);
            this.AdminSigningroupBox.Name = "AdminSigningroupBox";
            this.AdminSigningroupBox.Size = new System.Drawing.Size(227, 315);
            this.AdminSigningroupBox.TabIndex = 13;
            this.AdminSigningroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // importantLabel
            // 
            this.importantLabel.AutoSize = true;
            this.importantLabel.Location = new System.Drawing.Point(6, 45);
            this.importantLabel.Name = "importantLabel";
            this.importantLabel.Size = new System.Drawing.Size(62, 13);
            this.importantLabel.TabIndex = 1;
            this.importantLabel.Text = "* mandstory";
            // 
            // usernamatextBox
            // 
            this.usernamatextBox.Location = new System.Drawing.Point(13, 70);
            this.usernamatextBox.MaxLength = 9;
            this.usernamatextBox.Name = "usernamatextBox";
            this.usernamatextBox.Size = new System.Drawing.Size(136, 20);
            this.usernamatextBox.TabIndex = 2;
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(13, 126);
            this.FirstNametextBox.MaxLength = 50;
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(136, 20);
            this.FirstNametextBox.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(13, 186);
            this.LastNameTextBox.MaxLength = 9;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(13, 253);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(140, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(176, 333);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(75, 23);
            this.signButton.TabIndex = 14;
            this.signButton.Text = "Sign Me";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.SignButtonClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(17, 276);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "using agreement";
            // 
            // termRadioButton
            // 
            this.termRadioButton.AutoSize = true;
            this.termRadioButton.Location = new System.Drawing.Point(16, 292);
            this.termRadioButton.Name = "termRadioButton";
            this.termRadioButton.Size = new System.Drawing.Size(186, 17);
            this.termRadioButton.TabIndex = 10;
            this.termRadioButton.TabStop = true;
            this.termRadioButton.Text = "I read the agreement and I accept";
            this.termRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClientSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::bikeRent.Properties.Resources.rentBook;
            this.ClientSize = new System.Drawing.Size(732, 380);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.AdminSigningroupBox);
            this.Controls.Add(this.clientPanel);
            this.Name = "ClientSignin";
            this.Text = "ClientSignin";
            this.Load += new System.EventHandler(this.ClientSignin_Load);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            this.AdminSigningroupBox.ResumeLayout(false);
            this.AdminSigningroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Panel clientPanel;
        protected System.Windows.Forms.Label emailLabel;
        protected System.Windows.Forms.TextBox phoneTextBox;
        protected System.Windows.Forms.TextBox emailTextBox;
        protected System.Windows.Forms.ToolTip emailToolTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox FirstNametextBox;
        public System.Windows.Forms.TextBox usernamatextBox;
        public System.Windows.Forms.Button signButton;
        public System.Windows.Forms.RadioButton termRadioButton;
        public System.Windows.Forms.Label importantLabel;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox AdminSigningroupBox;
    }
}