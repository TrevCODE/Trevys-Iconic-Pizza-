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
        private LoginPage loginPage;
        public LandingPage()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {loginPage = new LoginPage();
            if (!loginPage.IsOpen)
            {
                
                loginButton.Enabled = false;
            } else
            {
                loginButton.Enabled = true;
            }
        }

    }
}
