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
    public partial class MenuPage : Form
    {

        Pizza pizza;
        public MenuPage()
        {
            InitializeComponent();
        }

        private void pizzaButton_Click(object sender, EventArgs e)
        {

            // Assuming loginPage is an instance of LoginPage
            PizzaPage pizzaPage = new PizzaPage();

            // Handle the FormClosed event
            pizzaPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                pizzaButton.Enabled = true;
            };

            pizzaPage.Show();
            pizzaButton.Enabled = false;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            // Assuming loginPage is an instance of LoginPage
            DrinkPage drinkPage = new DrinkPage();

            // Handle the FormClosed event
            drinkPage.FormClosed += (s, args) =>
            {
                // Re-enable the loginButton when the LoginPage is closed
                drinkButton.Enabled = true;
            };

            drinkPage.Show();
            drinkButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<String> test = new List<string>();
            test.Add("burger");
            Pizza p1 = new Pizza("Original", 's', test);
            decimal pizzaPrice = p1.calculatePriceForReadyPizza(); // Access the Price property to trigger the calculation
            richTextBox1.Text = pizzaPrice.ToString();
        }
    }
}
