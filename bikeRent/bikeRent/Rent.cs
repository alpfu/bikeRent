using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Npgsql;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikeRent
{
    public partial class Rent : Form
    {
        String username;
        int N = 50;
       
        String today = DateTime.Today.ToString("yyyy-MM-dd");
        public Rent(String username)
        {
            this.username = username;
            InitializeComponent();
            displaylistBox();

        }
        public void displaylistBox()
        {
            this.RentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.RentDataGridView.MultiSelect = false;
           // this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmState_FormClosed);
            String connString = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            using (NpgsqlConnection dbConn = new NpgsqlConnection(connString))
            {
                dbConn.Open();
                
                string cmdString = "select bike.bikeid,bike.day_price,bike.model from bike where (bikeid,bikeid) not in ( select book.bikeid,rent.bikeid from book full outer join rent on rentdate='"+today+"' and book.begindate>='"+today+"' and book.enddate<='"+today+"' and book.bikeid=rent.bikeid);";

                NpgsqlCommand cmd = new NpgsqlCommand(cmdString, dbConn);

                NpgsqlDataAdapter da= new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet(); da.Fill(ds,"bikes");
                RentDataGridView.DataSource = ds.Tables["bikes"] ;
                
                
            }
        }

        private void rentButtonClicked(object sender, EventArgs e)
        {

        }

        private void Rent_Load(object sender, EventArgs e)
        {

        }

        private void celldoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var currentRow = RentDataGridView.Rows[rowIndex];
            var currentBikeid = RentDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            var currentmodelid= RentDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Console.WriteLine(currentBikeid + "      " + currentmodelid);
         var  connection2 = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
        var conn = new NpgsqlConnection(connection2);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into rent values('" + currentBikeid + "','" + username + "','" + today + "')");
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully rended");
            displaylistBox(); //datagridview güncellenir kullanıcının ayrı bisikleti tekrar seçmesi engellenir.


        }

        private void RowClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
         /* ;*/

        }
    }
}
