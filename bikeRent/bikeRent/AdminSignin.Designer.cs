namespace bikeRent
{
    partial class AdminSignin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSignin));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernamatextBox = new System.Windows.Forms.TextBox();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.AdminSigningroupBox = new System.Windows.Forms.GroupBox();
            this.importantLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.termRadioButton = new System.Windows.Forms.RadioButton();
            this.ChoosePhotoButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.signButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.AdminSigningroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Gray;
            this.usernameLabel.Location = new System.Drawing.Point(6, 16);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // usernamatextBox
            // 
            this.usernamatextBox.Location = new System.Drawing.Point(6, 50);
            this.usernamatextBox.MaxLength = 9;
            this.usernamatextBox.Name = "usernamatextBox";
            this.usernamatextBox.Size = new System.Drawing.Size(215, 20);
            this.usernamatextBox.TabIndex = 1;
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(6, 117);
            this.FirstNametextBox.MaxLength = 50;
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(215, 20);
            this.FirstNametextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(9, 189);
            this.LastNameTextBox.MaxLength = 50;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(215, 20);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(9, 249);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(215, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Gray;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 90);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.BackColor = System.Drawing.Color.Gray;
            this.LastNamelabel.Location = new System.Drawing.Point(6, 162);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(58, 13);
            this.LastNamelabel.TabIndex = 6;
            this.LastNamelabel.Text = "Last Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Gray;
            this.passwordLabel.Location = new System.Drawing.Point(6, 222);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(570, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(157, 163);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // AdminSigningroupBox
            // 
            this.AdminSigningroupBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminSigningroupBox.Controls.Add(this.importantLabel);
            this.AdminSigningroupBox.Controls.Add(this.linkLabel1);
            this.AdminSigningroupBox.Controls.Add(this.termRadioButton);
            this.AdminSigningroupBox.Controls.Add(this.usernamatextBox);
            this.AdminSigningroupBox.Controls.Add(this.usernameLabel);
            this.AdminSigningroupBox.Controls.Add(this.passwordTextBox);
            this.AdminSigningroupBox.Controls.Add(this.passwordLabel);
            this.AdminSigningroupBox.Controls.Add(this.firstNameLabel);
            this.AdminSigningroupBox.Controls.Add(this.LastNamelabel);
            this.AdminSigningroupBox.Controls.Add(this.LastNameTextBox);
            this.AdminSigningroupBox.Controls.Add(this.FirstNametextBox);
            this.AdminSigningroupBox.Location = new System.Drawing.Point(40, 16);
            this.AdminSigningroupBox.Name = "AdminSigningroupBox";
            this.AdminSigningroupBox.Size = new System.Drawing.Size(228, 332);
            this.AdminSigningroupBox.TabIndex = 9;
            this.AdminSigningroupBox.TabStop = false;
            this.AdminSigningroupBox.Enter += new System.EventHandler(this.AdminSigningroupBox_Enter);
            // 
            // importantLabel
            // 
            this.importantLabel.AutoSize = true;
            this.importantLabel.BackColor = System.Drawing.Color.DimGray;
            this.importantLabel.Location = new System.Drawing.Point(6, 34);
            this.importantLabel.Name = "importantLabel";
            this.importantLabel.Size = new System.Drawing.Size(73, 13);
            this.importantLabel.TabIndex = 14;
            this.importantLabel.Text = "* is mandatory";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.Location = new System.Drawing.Point(6, 283);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "using agreement";
            // 
            // termRadioButton
            // 
            this.termRadioButton.AutoSize = true;
            this.termRadioButton.BackColor = System.Drawing.Color.DarkGray;
            this.termRadioButton.Location = new System.Drawing.Point(9, 310);
            this.termRadioButton.Name = "termRadioButton";
            this.termRadioButton.Size = new System.Drawing.Size(186, 17);
            this.termRadioButton.TabIndex = 12;
            this.termRadioButton.TabStop = true;
            this.termRadioButton.Text = "I read the agreement and I accept";
            this.termRadioButton.UseVisualStyleBackColor = false;
            // 
            // ChoosePhotoButton
            // 
            this.ChoosePhotoButton.AutoSize = true;
            this.ChoosePhotoButton.ImageList = this.imageList1;
            this.ChoosePhotoButton.Location = new System.Drawing.Point(570, 189);
            this.ChoosePhotoButton.Name = "ChoosePhotoButton";
            this.ChoosePhotoButton.Size = new System.Drawing.Size(82, 23);
            this.ChoosePhotoButton.TabIndex = 10;
            this.ChoosePhotoButton.Text = "choose photo";
            this.ChoosePhotoButton.UseVisualStyleBackColor = false;
            this.ChoosePhotoButton.Click += new System.EventHandler(this.chooseButtonClicked);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(295, 310);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(75, 23);
            this.signButton.TabIndex = 11;
            this.signButton.Text = "Sign Me";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButtoClicked);
            // 
            // AdminSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(739, 381);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.ChoosePhotoButton);
            this.Controls.Add(this.AdminSigningroupBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "AdminSignin";
            this.Text = "Admin Signin";
            this.Load += new System.EventHandler(this.AdminSignin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.AdminSigningroupBox.ResumeLayout(false);
            this.AdminSigningroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ChoosePhotoButton;
        private System.Windows.Forms.ImageList imageList1;
        
        public System.Windows.Forms.GroupBox AdminSigningroupBox;
        public System.Windows.Forms.Button signButton;
        protected System.Windows.Forms.TextBox usernamatextBox;
        protected System.Windows.Forms.TextBox FirstNametextBox;
        protected System.Windows.Forms.TextBox LastNameTextBox;
        protected System.Windows.Forms.TextBox passwordTextBox;
   
        public System.Windows.Forms.Label importantLabel;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.RadioButton termRadioButton;
    }
}