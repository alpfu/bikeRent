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
    public partial class choosingAccountType: Form
    {
        public choosingAccountType()
        {
            InitializeComponent();
        }

        private void clientSigninChanged(object sender, EventArgs e)
        {
            ClientSignin clientSign = new ClientSignin();
            clientSign.Show();
            this.Close();
        }

        private void adminSigninChanged(object sender, EventArgs e)
        {
            AdminSignin adminSign = new AdminSignin();
            adminSign.Show();
            this.Close();
        }
    }
}
