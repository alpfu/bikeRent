namespace bikeRent
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.AdminPanelControl = new System.Windows.Forms.TabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.importantLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.usernamatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnamelabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.bikesTab = new System.Windows.Forms.TabPage();
            this.BikedataGridView = new System.Windows.Forms.DataGridView();
            this.addBiketabPage = new System.Windows.Forms.TabPage();
            this.DeletetabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BiketextBox = new System.Windows.Forms.TextBox();
            this.DayPricetextBox = new System.Windows.Forms.TextBox();
            this.ModeltextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.bikeidWarnLabel = new System.Windows.Forms.Label();
            this.DeletedataGridView = new System.Windows.Forms.DataGridView();
            this.AdminPanelControl.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.bikesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BikedataGridView)).BeginInit();
            this.addBiketabPage.SuspendLayout();
            this.DeletetabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeletedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPanelControl
            // 
            this.AdminPanelControl.Controls.Add(this.profileTab);
            this.AdminPanelControl.Controls.Add(this.bikesTab);
            this.AdminPanelControl.Controls.Add(this.addBiketabPage);
            this.AdminPanelControl.Controls.Add(this.DeletetabPage);
            this.AdminPanelControl.Location = new System.Drawing.Point(11, 9);
            this.AdminPanelControl.Name = "AdminPanelControl";
            this.AdminPanelControl.SelectedIndex = 0;
            this.AdminPanelControl.Size = new System.Drawing.Size(787, 433);
            this.AdminPanelControl.TabIndex = 0;
            this.AdminPanelControl.Enter += new System.EventHandler(this.BikesEntered);
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.importantLabel);
            this.profileTab.Controls.Add(this.SaveButton);
            this.profileTab.Controls.Add(this.passwordTextBox);
            this.profileTab.Controls.Add(this.LastNameTextBox);
            this.profileTab.Controls.Add(this.FirstNametextBox);
            this.profileTab.Controls.Add(this.usernamatextBox);
            this.profileTab.Controls.Add(this.label4);
            this.profileTab.Controls.Add(this.label3);
            this.profileTab.Controls.Add(this.fnamelabel);
            this.profileTab.Controls.Add(this.usernameLabel);
            this.profileTab.Location = new System.Drawing.Point(4, 22);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(779, 407);
            this.profileTab.TabIndex = 0;
            this.profileTab.Text = "Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            this.profileTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // importantLabel
            // 
            this.importantLabel.AutoSize = true;
            this.importantLabel.Location = new System.Drawing.Point(26, 49);
            this.importantLabel.Name = "importantLabel";
            this.importantLabel.Size = new System.Drawing.Size(52, 13);
            this.importantLabel.TabIndex = 9;
            this.importantLabel.Text = "* required";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(31, 351);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(24, 298);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(186, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(24, 221);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(24, 148);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(186, 20);
            this.FirstNametextBox.TabIndex = 5;
            // 
            // usernamatextBox
            // 
            this.usernamatextBox.Location = new System.Drawing.Point(24, 70);
            this.usernamatextBox.MaxLength = 9;
            this.usernamatextBox.Name = "usernamatextBox";
            this.usernamatextBox.Size = new System.Drawing.Size(186, 20);
            this.usernamatextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password *";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname *";
            // 
            // fnamelabel
            // 
            this.fnamelabel.AutoSize = true;
            this.fnamelabel.Location = new System.Drawing.Point(23, 113);
            this.fnamelabel.Name = "fnamelabel";
            this.fnamelabel.Size = new System.Drawing.Size(59, 13);
            this.fnamelabel.TabIndex = 1;
            this.fnamelabel.Text = "Firstname *";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(24, 31);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(62, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username *";
            // 
            // bikesTab
            // 
            this.bikesTab.Controls.Add(this.BikedataGridView);
            this.bikesTab.Location = new System.Drawing.Point(4, 22);
            this.bikesTab.Name = "bikesTab";
            this.bikesTab.Padding = new System.Windows.Forms.Padding(3);
            this.bikesTab.Size = new System.Drawing.Size(779, 407);
            this.bikesTab.TabIndex = 2;
            this.bikesTab.Text = "Bikes";
            this.bikesTab.UseVisualStyleBackColor = true;
            // 
            // BikedataGridView
            // 
            this.BikedataGridView.AllowUserToOrderColumns = true;
            this.BikedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BikedataGridView.Location = new System.Drawing.Point(20, 12);
            this.BikedataGridView.Name = "BikedataGridView";
            this.BikedataGridView.Size = new System.Drawing.Size(461, 395);
            this.BikedataGridView.TabIndex = 0;
            this.BikedataGridView.Enter += new System.EventHandler(this.BikesShowEntered);
            // 
            // addBiketabPage
            // 
            this.addBiketabPage.Controls.Add(this.bikeidWarnLabel);
            this.addBiketabPage.Controls.Add(this.Addbutton);
            this.addBiketabPage.Controls.Add(this.ModeltextBox);
            this.addBiketabPage.Controls.Add(this.DayPricetextBox);
            this.addBiketabPage.Controls.Add(this.BiketextBox);
            this.addBiketabPage.Controls.Add(this.label5);
            this.addBiketabPage.Controls.Add(this.label2);
            this.addBiketabPage.Controls.Add(this.label1);
            this.addBiketabPage.Location = new System.Drawing.Point(4, 22);
            this.addBiketabPage.Name = "addBiketabPage";
            this.addBiketabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addBiketabPage.Size = new System.Drawing.Size(779, 407);
            this.addBiketabPage.TabIndex = 3;
            this.addBiketabPage.Text = "Add Bike";
            this.addBiketabPage.UseVisualStyleBackColor = true;
            // 
            // DeletetabPage
            // 
            this.DeletetabPage.Controls.Add(this.DeletedataGridView);
            this.DeletetabPage.Location = new System.Drawing.Point(4, 22);
            this.DeletetabPage.Name = "DeletetabPage";
            this.DeletetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DeletetabPage.Size = new System.Drawing.Size(779, 407);
            this.DeletetabPage.TabIndex = 4;
            this.DeletetabPage.Text = "Delete Bike";
            this.DeletetabPage.UseVisualStyleBackColor = true;
            this.DeletetabPage.Click += new System.EventHandler(this.DeleteBikesEntered);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bike ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Day price ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Model";
            // 
            // BiketextBox
            // 
            this.BiketextBox.Location = new System.Drawing.Point(23, 51);
            this.BiketextBox.MaxLength = 9;
            this.BiketextBox.Name = "BiketextBox";
            this.BiketextBox.Size = new System.Drawing.Size(163, 20);
            this.BiketextBox.TabIndex = 3;
            // 
            // DayPricetextBox
            // 
            this.DayPricetextBox.Location = new System.Drawing.Point(24, 151);
            this.DayPricetextBox.Name = "DayPricetextBox";
            this.DayPricetextBox.Size = new System.Drawing.Size(162, 20);
            this.DayPricetextBox.TabIndex = 4;
            // 
            // ModeltextBox
            // 
            this.ModeltextBox.Location = new System.Drawing.Point(23, 236);
            this.ModeltextBox.MaxLength = 30;
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.Size = new System.Drawing.Size(163, 20);
            this.ModeltextBox.TabIndex = 5;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(23, 284);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 6;
            this.Addbutton.Text = "Add Bike";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.AddBikeClicked);
            // 
            // bikeidWarnLabel
            // 
            this.bikeidWarnLabel.AutoSize = true;
            this.bikeidWarnLabel.Location = new System.Drawing.Point(85, 22);
            this.bikeidWarnLabel.Name = "bikeidWarnLabel";
            this.bikeidWarnLabel.Size = new System.Drawing.Size(0, 13);
            this.bikeidWarnLabel.TabIndex = 7;
            // 
            // DeletedataGridView
            // 
            this.DeletedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeletedataGridView.Location = new System.Drawing.Point(20, 20);
            this.DeletedataGridView.Name = "DeletedataGridView";
            this.DeletedataGridView.Size = new System.Drawing.Size(343, 364);
            this.DeletedataGridView.TabIndex = 0;
            this.DeletedataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteClicked);
            this.DeletedataGridView.Enter += new System.EventHandler(this.DeleteBikeEntered);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(819, 454);
            this.Controls.Add(this.AdminPanelControl);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.AdminPanelControl.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            this.bikesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BikedataGridView)).EndInit();
            this.addBiketabPage.ResumeLayout(false);
            this.addBiketabPage.PerformLayout();
            this.DeletetabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeletedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminPanelControl;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.TabPage bikesTab;
        private System.Windows.Forms.DataGridView BikedataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourspriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.TextBox usernamatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fnamelabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label importantLabel;
        private System.Windows.Forms.TabPage addBiketabPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage DeletetabPage;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox ModeltextBox;
        private System.Windows.Forms.TextBox DayPricetextBox;
        private System.Windows.Forms.TextBox BiketextBox;
        private System.Windows.Forms.Label bikeidWarnLabel;
        private System.Windows.Forms.DataGridView DeletedataGridView;
    }
}