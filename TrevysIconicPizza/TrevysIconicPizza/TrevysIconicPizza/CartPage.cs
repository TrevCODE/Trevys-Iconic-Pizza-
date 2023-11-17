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


    }
}
