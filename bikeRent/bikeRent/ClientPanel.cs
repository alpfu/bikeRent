using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikeRent
{
    public partial class ClientPanel : Form
    {
        String username;
        String password;
       
        public ClientPanel(String username,String password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void ClientPanel_Load(object sender, EventArgs e)
        {

        }

        private void rentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SettingsClicked(object sender, EventArgs e)
        {
            ClientSettings cSettigs = new ClientSettings(username);
            cSettigs.Show();
        }

        private void rentClicked(object sender, EventArgs e)
        {
            Rent rent = new Rent(username);
            rent.Show();
        }

        private void bookClicked(object sender, EventArgs e)
        {
            Book newBook = new Book(username);
            newBook.Show();
        }

        private void showRentsClicked(object sender, EventArgs e)
        {
            ShowRentBook showRent = new ShowRentBook(username,"r");
            showRent.Show();
        }

        private void showBookClicked(object sender, EventArgs e)
        {
            ShowRentBook showBook = new ShowRentBook(username, "b");
            showBook.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();// login forma atılır.
        }
    }
}
