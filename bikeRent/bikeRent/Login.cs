using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace bikeRent
{
    public partial class Login : Form
    {
        String username;
        String password;
        String usertype;

        public Login()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void donthaveaccount(object sender, EventArgs e)
        {// kullanıcıdan kayıt olunacak kullanıcı tipini seçmes istenilir.
         //musteri ise s
            choosingAccountType type = new choosingAccountType();
           
            type.Show();
        }
        private String connection;
        private void LoginButton(object sender, EventArgs e)
        {//catalogu değiştir.
            connection = "Server=localhost;port=5432;Database =bikeBookv1;username=postgres;Password=locklock";
            var  conn = new NpgsqlConnection(connection);
            conn.Open();
              var cmd = new NpgsqlCommand("select  username,password,usertype from users where username ='"+usernameTextBox.Text+"' and password='"+passwordTextBox.Text+"';",conn) ;
            
            {
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    username = (String) reader.GetValue(0);
                    password = (String)reader.GetValue(1);
                    usertype = (String)reader.GetValue(2);

                }
                
                Console.WriteLine(username + "   " +password +"  "+ usertype );
                if(username=="" && password=="")
                {
                    MessageBox.Show("username and password must be valid ,try again later");

                }
                else if(usertype=="admin")
                {
                    AdminPanel adminPanel = new AdminPanel(username,password);
                    adminPanel.Show();
                  //  this.Close();
                }
                else if(usertype=="client")
                {
                    ClientPanel clientPanel = new ClientPanel(username,password);
                    clientPanel.Show();
                   // this.Close();
                    
                }
                else
                {
                    MessageBox.Show("user not found.");
                }


             
            }
    

        // kullanici admin ise admin panel goruntulenir
        // kullanici musteri ise musteri panel goruntulenir
        }
    }
}
