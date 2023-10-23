using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrevysIconicPizza
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool alreadyOpen = false;
            var login = new LoginPage();
            login.Show();
            alreadyOpen = true;

            if(alreadyOpen)
            {
                loginButton.Enabled = false;
            }
        }
    }
}
