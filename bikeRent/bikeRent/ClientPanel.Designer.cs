namespace bikeRent
{
    partial class ClientPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.makeRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haveBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.rentsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.shipsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.profileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profileToolStripMenuItem.Image")));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.profileToolStripMenuItem.Text = "profile";
            this.profileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsClicked);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // rentsToolStripMenuItem
            // 
            this.rentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeRentToolStripMenuItem});
            this.rentsToolStripMenuItem.Name = "rentsToolStripMenuItem";
            this.rentsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.rentsToolStripMenuItem.Text = "rents";
            this.rentsToolStripMenuItem.Click += new System.EventHandler(this.rentsToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haveBookToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "books";
            // 
            // shipsToolStripMenuItem
            // 
            this.shipsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentsToolStripMenuItem1,
            this.booksToolStripMenuItem1});
            this.shipsToolStripMenuItem.Name = "shipsToolStripMenuItem";
            this.shipsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.shipsToolStripMenuItem.Text = "ships";
            // 
            // rentsToolStripMenuItem1
            // 
            this.rentsToolStripMenuItem1.Name = "rentsToolStripMenuItem1";
            this.rentsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.rentsToolStripMenuItem1.Text = "rents";
            this.rentsToolStripMenuItem1.Click += new System.EventHandler(this.showRentsClicked);
            // 
            // booksToolStripMenuItem1
            // 
            this.booksToolStripMenuItem1.Name = "booksToolStripMenuItem1";
            this.booksToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.booksToolStripMenuItem1.Text = "books";
            this.booksToolStripMenuItem1.Click += new System.EventHandler(this.showBookClicked);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(621, 220);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // makeRentToolStripMenuItem
            // 
            this.makeRentToolStripMenuItem.Name = "makeRentToolStripMenuItem";
            this.makeRentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeRentToolStripMenuItem.Text = "have rent ";
            this.makeRentToolStripMenuItem.Click += new System.EventHandler(this.rentClicked);
            // 
            // haveBookToolStripMenuItem
            // 
            this.haveBookToolStripMenuItem.Name = "haveBookToolStripMenuItem";
            this.haveBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.haveBookToolStripMenuItem.Text = "have book";
            this.haveBookToolStripMenuItem.Click += new System.EventHandler(this.bookClicked);
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 661);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientPanel";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.ClientPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem makeRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haveBookToolStripMenuItem;
    }
}