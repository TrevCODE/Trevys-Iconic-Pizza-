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
        LoginPage loginPage = new LoginPage();
        public LandingPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Assuming loginPage is an instance of LoginPage
            PizzaPage pizza = new PizzaPage();

            // Handle the FormClosed event
            pizza.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                loginButton.Enabled = true;
            };

            pizza.Show();
            loginButton.Enabled = false;
        }
    }
}
