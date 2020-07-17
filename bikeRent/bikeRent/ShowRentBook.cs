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
    public partial class ShowRentBook : Form
    {
        String username;
        String whichShow;
        int totalPrice = 0;
        public ShowRentBook(String username ,String whichShow)
        {
            this.username = username;
            this.whichShow = whichShow;
            InitializeComponent();
            displayRows(whichShow);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var currentRow = dataGridView1.Rows[rowIndex];
            var currentBikeid = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            var connection2 = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            var conn = new NpgsqlConnection(connection2);
            NpgsqlCommand cmd = null;
            if (whichShow==("r")) // rentten silme yapılacak
            {
                String currentRendDate = dataGridView1.Rows[rowIndex].Cells[1].EditedFormattedValue.ToString();
               
                conn.Open();
                //kullanıcının aynı bisikleti daha önceden almasına olanak verildiği için tarihe göre silme yapılır.
                  cmd=new NpgsqlCommand("delete from rent where (bikeid='" +currentBikeid + "'and username='" + username + "'and rentdate='" +currentRendDate+ "')");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("deleting from rent successfull");
                displayRows("r");
            }
            else //booktan silme yapılacak
            {


                String currentBeginDate = dataGridView1.Rows[rowIndex].Cells[1].EditedFormattedValue.ToString();
                String  currentEndDate = dataGridView1.Rows[rowIndex].Cells[2].EditedFormattedValue.ToString();
                conn.Open();
                cmd = new NpgsqlCommand("delete from book where (bikeid='" + currentBikeid + "'and username='" + username + "'and begindate='" + currentBeginDate+ "' and enddate='"+currentEndDate+"')");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                
                MessageBox.Show("deleting from book successfull");
                displayRows("b");
            }


        }
        public void displayRows(String r)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            // this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmState_FormClosed);
            String connString = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            using (NpgsqlConnection dbConn = new NpgsqlConnection(connString))
            {
                dbConn.Open();
                string cmdString = null;
                if (r.Equals("r")) // rent display edilmek isteniliyorsa.
                {
                    cmdString = "select bikeid,rentdate from rent  where username='" + username + "'";
                }
                else//book display
                {
                    cmdString = "select bikeid,begindate,enddate from book  where username='" + username + "'";
                }


                NpgsqlCommand cmd = new NpgsqlCommand(cmdString, dbConn);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
               
                DataSet ds = new DataSet(); da.Fill(ds, "bikes");
                dataGridView1.DataSource = ds.Tables["bikes"];
                dataGridView1.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";
                if (r=="b") // book olması durumunda date içeren sutunların formatı değiştirildi.
                {
                   
                    dataGridView1.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";

                }

               
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
