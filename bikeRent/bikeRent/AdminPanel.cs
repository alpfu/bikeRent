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
    public partial class AdminPanel : Form
    {
        String username = null;
        String lastUserName;
        String password;
        String fname;
        String lname;

        public AdminPanel(String username, String password)
        {
            this.lastUserName = username;
            this.password = password;
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            String connection = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            NpgsqlConnection conn = new NpgsqlConnection(connection);
            conn.Open();
            username = null;
            fname = FirstNametextBox.Text;
            lname = LastNameTextBox.Text;
            password = passwordTextBox.Text;
            if (usernamatextBox.Text == "" || fname == "" || lname == "" || password == "")
            {
                MessageBox.Show("mandatory fields required");
            }
            else
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select  username from users where username ='" + usernamatextBox.Text + "';", conn);

                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        username = (String)reader.GetValue(0);
                        Console.WriteLine(username);

                    }
                    conn.Close();
                    Console.WriteLine("çıktı" + username);
                    Console.WriteLine((username != null) && (username.Equals(usernamatextBox.Text)));
                    Console.WriteLine(usernamatextBox.Text);
                    if ((username != null))// kullanıcı adıın daha önce alınması durumu
                    {
                        usernamatextBox.ForeColor = Color.Red;
                        importantLabel.Text = "username was took by another person ,please change username";
                        Console.WriteLine("dgffsrbfb");
                    }

                    //alanların uzunluk kontrolü
                    else if (password.Length > 20 || usernamatextBox.Text.Length > 9 || fname.Length > 50 || lname.Length > 50 || password.Length > 20)//kullanıcı kaydı yapılır.
                    {
                        MessageBox.Show("length of that field must be like that ;username:9 ,first name 50 ,last name 50 ,password 20  ");
                    }
                    else // user aggreementın kabul edilmasiyle kullanıcı kaydı yapılır.
                    {
                        conn.Open();
                        NpgsqlCommand updateUsercmd = new NpgsqlCommand("update  users set(username,fname,lname,password)= ('" + usernamatextBox.Text + "','" + fname + "','" + lname + "','" + password + "') where username='" + lastUserName + "'", conn);
                        //   NpgsqlCommand updateAdmincmd = new NpgsqlCommand("Update admin set username = '" + usernamatextBox.Text + "' where username='" + usernamatextBox.Text + "'", conn);
                        updateUsercmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Changes saved successfull");
                        usernamatextBox.ForeColor = Color.Black;
                        //   conn.Open();
                        //    updateAdmincmd.ExecuteNonQuery();
                        //  conn.Close();
                    }

                }
            }

        }

        private void BikesEntered(object sender, EventArgs e)
        {
            BikesShowEntered(sender, e);
            DeleteBikeEntered(sender, e);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBikeClicked(object sender, EventArgs e)
        {
            String bikeid = null;

            String connection = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            var conn = new NpgsqlConnection(connection);
            conn.Open();
            if (BiketextBox.Text == "" || ModeltextBox.Text == "" || DayPricetextBox.Text == "")
            {
                MessageBox.Show("mandatory fields required");
            }
            else
            {//bike idnin var olup olmadığı kontrol edilir.
                NpgsqlCommand cmd = new NpgsqlCommand("select bikeid from bike where bikeid ='" + BiketextBox.Text + "';", conn);

                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bikeid = (String)reader.GetValue(0);
                        Console.WriteLine(username);

                    }
                    conn.Close();
                    Console.WriteLine(username);
                    if ((bikeid != null))// bikeidnin daha önce alınması durumu
                    {
                        BiketextBox.ForeColor = Color.Red;
                        bikeidWarnLabel.Text = "bikeid was took by another bike ,please change bikeid";

                    }

                    //alanların uzunluk kontrolü

                    else //bisiklet kaydı yapılır.
                    {
                        conn.Open();
                        String cmdString =("insert into bike values('" + BiketextBox.Text + "','" + DayPricetextBox.Text + "','" + ModeltextBox.Text + "')");
                       
                        NpgsqlCommand cmd2 = new NpgsqlCommand(cmdString,conn);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully registered ");
                    }

                    conn.Close();
                }
            }
        }

        public void display()
        {
            this.DeletedataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DeletedataGridView.MultiSelect = false;
            // this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmState_FormClosed);
            String connString = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            using (NpgsqlConnection dbConn = new NpgsqlConnection(connString))
            {
                dbConn.Open();

                string cmdString = "select bike.bikeid,bike.day_price,bike.model from bike";

                NpgsqlCommand cmd = new NpgsqlCommand(cmdString, dbConn);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet(); da.Fill(ds, "bikes");
                DeletedataGridView.DataSource = ds.Tables["bikes"];
            }

        }

        private void DeleteClicked(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var currentRow = DeletedataGridView.Rows[rowIndex];
            var currentBikeid =DeletedataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            var connection2 = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            var conn = new NpgsqlConnection(connection2);
            NpgsqlCommand cmd = null;
                conn.Open();
                //kullanıcının aynı bisikleti daha önceden almasına olanak verildiği için tarihe göre silme yapılır.
                cmd = new NpgsqlCommand("delete from bike where (bikeid='" + currentBikeid + "')");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("deleting bike successfull");
                display();
            BikesShowEntered(sender, e);

        }

        private void DeleteBikesEntered(object sender, EventArgs e)
        {
            display();
        }

        private void BikesShowEntered(object sender, EventArgs e)
        {
            this.BikedataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.BikedataGridView.MultiSelect = false;
            // this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmState_FormClosed);
            String connString = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            using (NpgsqlConnection dbConn = new NpgsqlConnection(connString))
            {
                dbConn.Open();

                string cmdString = "select bike.bikeid,bike.day_price,bike.model from bike";

                NpgsqlCommand cmd = new NpgsqlCommand(cmdString, dbConn);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet(); da.Fill(ds, "bikes");
                BikedataGridView.DataSource = ds.Tables["bikes"];
            }

        }

        private void DeleteBikeEntered(object sender, EventArgs e)
        {
            this.DeletedataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DeletedataGridView.MultiSelect = false;
            // this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmState_FormClosed);
            String connString = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            using (NpgsqlConnection dbConn = new NpgsqlConnection(connString))
            {
                dbConn.Open();

                string cmdString = "select bike.bikeid,bike.day_price,bike.model from bike";

                NpgsqlCommand cmd = new NpgsqlCommand(cmdString, dbConn);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet(); da.Fill(ds, "bikes");
                DeletedataGridView.DataSource = ds.Tables["bikes"];
            }

        }
    }
}
