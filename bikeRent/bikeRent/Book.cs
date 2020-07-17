using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikeRent
{
    public partial class Book : Form
    {
        String username;
        String beginDate = null;
        String endDate = null;
        String today = DateTime.Today.ToString("yyyy-MM-dd");
        public Book(String username)
        {
            this.username = username;
          
            InitializeComponent();
          
        }
         public void displayDataGridView()
        {
            if (beginDate == null || endDate == null)
            {
                MessageBox.Show("begin date and end date must be selected");
            }
            else if(beginDate.CompareTo(endDate)==1 ||beginDate.CompareTo(today)==-1)
            {
                MessageBox.Show("begin date must be smaller than or equal end date and must be bigger than or equal today");
            }
            else
            {
                this.BookdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                this.BookdataGridView.MultiSelect = false;
                // this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmState_FormClosed);
                String connString = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
                using (NpgsqlConnection dbConn = new NpgsqlConnection(connString))
                {
                    dbConn.Open();

                    string cmdString = "select * from bike where bikeid not in((select book.bikeid from book where((begindate between '" + beginDate + "' and '" + endDate + "') or(begindate = '" + beginDate + "')  or(begindate = '" + endDate + "') or(enddate between '" + beginDate + "' and '2020-01-02') or(enddate = '" + endDate + "')or(enddate = '" + beginDate + "') ))  union(select rent.bikeid from rent  where rent.rentdate = '" + beginDate/*today olması durumunda izin vermez*/+ "'))";

                    NpgsqlCommand cmd = new NpgsqlCommand(cmdString, dbConn);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet(); da.Fill(ds, "bikes");
                    BookdataGridView.DataSource = ds.Tables["bikes"];
                }
            }
        }
        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var currentRow = BookdataGridView.Rows[rowIndex];
            var currentBikeid = BookdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            var currentmodelid = BookdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Console.WriteLine(currentBikeid + "      " + currentmodelid);
            var connection2 = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            var conn = new NpgsqlConnection(connection2);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into book values('" + currentBikeid + "','" + username + "','" + beginDate+ "','"+endDate+"')");
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Booked succesfull");
            displayDataGridView();

        }

        private void endDateChanged(object sender, EventArgs e)
        {
            endDate = EnddateTimePicker.Value.ToString("yyyy-MM-dd");
            Console.WriteLine("enddate" + endDate);
        }

        private void beginDateChanged(object sender, EventArgs e)
        {
            beginDate = begindateTimePicker.Value.ToString("yyyy-MM-dd");
            Console.WriteLine("begin date " + beginDate);
        }

        private void BringButtonClicked(object sender, EventArgs e)
        {
            displayDataGridView();
        }
    }
}
