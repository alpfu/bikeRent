namespace bikeRent
{
    partial class Rent
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
            this.Rentbutton = new System.Windows.Forms.Button();
            this.RentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Rentbutton
            // 
            this.Rentbutton.Location = new System.Drawing.Point(462, 390);
            this.Rentbutton.Name = "Rentbutton";
            this.Rentbutton.Size = new System.Drawing.Size(75, 23);
            this.Rentbutton.TabIndex = 2;
            this.Rentbutton.Text = "Rent";
            this.Rentbutton.UseVisualStyleBackColor = true;
            this.Rentbutton.Click += new System.EventHandler(this.rentButtonClicked);
            // 
            // RentDataGridView
            // 
            this.RentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.RentDataGridView.Name = "RentDataGridView";
            this.RentDataGridView.Size = new System.Drawing.Size(432, 401);
            this.RentDataGridView.TabIndex = 3;
            this.RentDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.celldoubleClicked);
            this.RentDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowClicked);
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bikeRent.Properties.Resources.bike;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RentDataGridView);
            this.Controls.Add(this.Rentbutton);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Rentbutton;
        private System.Windows.Forms.DataGridView RentDataGridView;
    }
}