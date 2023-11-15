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
        //Saves any error message 
        List<string> invalidResult = new List<string>();
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
            if (System.Text.RegularExpressions.Regex.IsMatch(firstNameTextBox.Text, "[^a-zA-Z]"))
            {
                invalidResult.Add("First name must contain only letters.\n");
                result = false;
            }
            return result;
        }

        private bool verifyLastName()
        {
            bool result = true;
            if (System.Text.RegularExpressions.Regex.IsMatch(lastNameTextBox.Text, "[^a-zA-Z]"))
            {
                invalidResult.Add("Last name must contain only letters.\n");
                result = false;
            }
            return result;
        }

        //private bool verifyUsername()
        //{
        //    bool result = true;
        //}
        private bool verifyPassword()
        {
            bool result = true;
            if (!passwordTextBox.Text.Equals(reEnterTextBox.Text)) {
                invalidResult.Add("Password does not match\n");
                result = false;
            }
            if(passwordTextBox.Text.Length < 8)
            {
                invalidResult.Add("Password must be eight characters or longer");
            }
            return result;
        }
        private bool verifyCard()
        {
            bool result = true;
            if (!System.Text.RegularExpressions.Regex.IsMatch(cardTextBox.Text, "/^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\\d{3})\\d{11})$/"))
            {
                invalidResult.Add("Invalid Card input\n");
                result = false;
            }
            return result; 
        }

        private void createAcountButton_Click(object sender, EventArgs e)
        {
            string text = "";

            verifyCard();
            verifyFirstName();
            verifyLastName();
            verifyPassword();

            if (invalidResult.Count != 0)
            {
                foreach (var result in invalidResult)
                {
                    text += result;
                }

                MessageBox.Show(text, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear text after loop
                text = "";

                // Clear the list of invalid results after displaying them
                invalidResult.Clear();
            }
        }
    }
}
