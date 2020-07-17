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
    public partial class ClientSignin : Form
    {
        String username;
        String fname;
        String lname;
        String password;

        public ClientSignin()
        {
            InitializeComponent();
        }
       
      /*  private void SignmeClicked(object sender, EventArgs e)
        {
 
        }*/

        private void ClientSignin_Load(object sender, EventArgs e)
        {

        }

        private void SignButtonClicked(object sender, EventArgs e)
        {
            String connection = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            var conn = new NpgsqlConnection(connection);
            conn.Open();
            username = null;
            fname = FirstNametextBox.Text;
            lname = LastNameTextBox.Text;
            password = passwordTextBox.Text;
            if (usernamatextBox.Text == "" || fname == "" || lname == "" || password == "" || emailTextBox.Text == "" || phoneTextBox.Text == "")
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
                    Console.WriteLine(username);
                    if ((username != null))// kullanıcı adıın daha önce alınması durumu
                    {
                        usernamatextBox.ForeColor = Color.Red;
                        importantLabel.Text = "username was took by another person ,please change username";

                    }

                    //alanların uzunluk kontrolü
                    else if (password.Length > 20 || usernamatextBox.Text.Length > 9 || fname.Length > 50 || lname.Length > 50 || password.Length > 20 || emailTextBox.Text.Length > 50 || phoneTextBox.Text.Length > 15)//kullanıcı kaydı yapılır.
                    {
                        MessageBox.Show("length of that field must be like that ;username:9 ,first name 50 ,last name 50 ,password 20 ,email 50 ,phone 15 ");
                    }
                    else if (termRadioButton.Checked.Equals(true)) // user aggreementın kabul edilmasiyle kullanıcı kaydı yapılır.
                    {
                        conn.Open();
                        NpgsqlCommand insertusercmd = new NpgsqlCommand("insert into users values('" + usernamatextBox.Text + "','" + fname + "','" + lname + "','" + password + "','client')", conn);
                        NpgsqlCommand insertClntcmd = new NpgsqlCommand("insert into client values('" + usernamatextBox.Text + "','" + emailTextBox.Text + "','" + phoneTextBox.Text + "');", conn);
                        insertusercmd.ExecuteNonQuery();
                        conn.Close();
                        conn.Open();
                        insertClntcmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully registered ");
                        ClientPanel newClientPanel = new ClientPanel(usernamatextBox.Text, password);
                        newClientPanel.Show();
                        this.Close();



                    }
                    else
                    {
                        MessageBox.Show("user aggrement must be read and accepted to use that system.");

                    }
                    conn.Close();

                }
            }

        }
    }
}
