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
    public partial class AdminSignin : Form
    {
        public AdminSignin()
        {
            InitializeComponent();
        }

        private void AdminSignin_Load(object sender, EventArgs e)
        {

        }

        private void AdminSigningroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void chooseButtonClicked(object sender, EventArgs e)
        {

        }
        String connection;
        String username;
        String fname;
        String lname;
        String password;

        public void signButtoClicked(object sender, EventArgs e)
        {
            connection = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            NpgsqlConnection conn = new NpgsqlConnection(connection);
            conn.Open();
             username=null;
            fname = FirstNametextBox.Text;
            lname = LastNameTextBox.Text;
            password = passwordTextBox.Text;
            if (usernamatextBox.Text == "" ||fname == "" || lname== "" || password == "")
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
                    Console.WriteLine("çıktı"+username);
                    Console.WriteLine((username != null) && (username.Equals(usernamatextBox.Text)));
                    Console.WriteLine(usernamatextBox.Text);
                    if ((username!=null))// kullanıcı adıın daha önce alınması durumu
                    { 
                        usernamatextBox.ForeColor = Color.Red;
                        importantLabel.Text = "username was took by another person ,please change username";
                        Console.WriteLine("dgffsrbfb");
                    }
                    
                    //alanların uzunluk kontrolü
                    else if (password.Length>20 || usernamatextBox.Text.Length>9||fname.Length>50 ||lname.Length>50 ||password.Length>20)//kullanıcı kaydı yapılır.
                    {
                        MessageBox.Show("length of that field must be like that ;username:9 ,first name 50 ,last name 50 ,password 20  ");
                    }
                    else if(termRadioButton.Checked.Equals(true)) // user aggreementın kabul edilmasiyle kullanıcı kaydı yapılır.
                    {
                        conn.Open();
                        NpgsqlCommand insertusercmd = new NpgsqlCommand("insert into users values('" + usernamatextBox.Text + "','" +fname + "','" + lname+ "','" + password+ "','admin')",conn);
                        NpgsqlCommand insertAdmncmd = new NpgsqlCommand("insert into admin values('" + usernamatextBox.Text + "')",conn);
                        insertusercmd.ExecuteNonQuery();
                        conn.Close();
                        conn.Open();
                        insertAdmncmd.ExecuteNonQuery();
                        conn.Close();
                        
                        AdminPanel newAdminPanel = new AdminPanel(usernamatextBox.Text, password);
                        newAdminPanel.Show();
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
