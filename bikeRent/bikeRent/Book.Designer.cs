namespace bikeRent
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.label1 = new System.Windows.Forms.Label();
            this.BookhelpProvider = new System.Windows.Forms.HelpProvider();
            this.BookdataGridView = new System.Windows.Forms.DataGridView();
            this.begindateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.beginDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bringbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // BookdataGridView
            // 
            this.BookdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookdataGridView.Location = new System.Drawing.Point(12, 12);
            this.BookdataGridView.Name = "BookdataGridView";
            this.BookdataGridView.Size = new System.Drawing.Size(460, 364);
            this.BookdataGridView.TabIndex = 2;
            this.BookdataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookCellClicked);
            // 
            // begindateTimePicker
            // 
            this.begindateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.begindateTimePicker.Location = new System.Drawing.Point(532, 130);
            this.begindateTimePicker.Name = "begindateTimePicker";
            this.begindateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.begindateTimePicker.TabIndex = 3;
            this.begindateTimePicker.ValueChanged += new System.EventHandler(this.beginDateChanged);
            // 
            // EnddateTimePicker
            // 
            this.EnddateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.EnddateTimePicker.Location = new System.Drawing.Point(532, 222);
            this.EnddateTimePicker.Name = "EnddateTimePicker";
            this.EnddateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EnddateTimePicker.TabIndex = 4;
            this.EnddateTimePicker.ValueChanged += new System.EventHandler(this.endDateChanged);
            // 
            // beginDateLabel
            // 
            this.beginDateLabel.AutoSize = true;
            this.beginDateLabel.Location = new System.Drawing.Point(529, 81);
            this.beginDateLabel.Name = "beginDateLabel";
            this.beginDateLabel.Size = new System.Drawing.Size(63, 13);
            this.beginDateLabel.TabIndex = 5;
            this.beginDateLabel.Text = "Begin Date ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Date ";
            // 
            // Bringbutton
            // 
            this.Bringbutton.Location = new System.Drawing.Point(538, 274);
            this.Bringbutton.Name = "Bringbutton";
            this.Bringbutton.Size = new System.Drawing.Size(75, 23);
            this.Bringbutton.TabIndex = 7;
            this.Bringbutton.Text = "Bring";
            this.Bringbutton.UseVisualStyleBackColor = true;
            this.Bringbutton.Click += new System.EventHandler(this.BringButtonClicked);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 388);
            this.Controls.Add(this.Bringbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.beginDateLabel);
            this.Controls.Add(this.EnddateTimePicker);
            this.Controls.Add(this.begindateTimePicker);
            this.Controls.Add(this.BookdataGridView);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider BookhelpProvider;
        private System.Windows.Forms.DataGridView BookdataGridView;
        private System.Windows.Forms.DateTimePicker begindateTimePicker;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker;
        private System.Windows.Forms.Label beginDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bringbutton;
    }
}