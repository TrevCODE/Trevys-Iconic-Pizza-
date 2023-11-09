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
    public partial class CreateAccountPage : Form
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void reEnterPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (reEnterPasswordCheckBox.Checked)
            {
                reEnterTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                reEnterTextBox.UseSystemPasswordChar = true;
            }
        }
        private bool verifyFirstName()
        {
            bool result = true;
            if(!System.Text.RegularExpressions.Regex.IsMatch(firstNameTextBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Name must be in letters");
                result = false;
            }
            return result;
        }
        private bool verifyLastName()
        {
            bool result = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(lastNameTextBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Name must be in letters");
                result = false;
            }
            return result;
        }
        private bool verifyUsername()
        {
            bool result = true;
        }
    }
}
