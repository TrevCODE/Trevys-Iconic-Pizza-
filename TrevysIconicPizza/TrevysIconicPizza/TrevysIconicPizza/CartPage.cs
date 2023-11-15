using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;

namespace TrevysIconicPizza
{
    public partial class CartPage : Form
    {
        public CartPage()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                cartListBox.Items.RemoveAt(cartListBox.SelectedIndex);
            }
        }
        //For testing
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Provide the full path or make sure the image is in the correct folder
                string imagePath = Path.Combine(@"C:\Users\2149315\Documents\GitHub\Trevys-Iconic-Pizza-\TrevysIconicPizza\TrevysIconicPizza\Images\", "pizzaPicture.png");

                // Load the image
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);

                // Add the image to the cartListBox
                cartListBox.Items.Add(new ImageStringCart("Pizza", image));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
