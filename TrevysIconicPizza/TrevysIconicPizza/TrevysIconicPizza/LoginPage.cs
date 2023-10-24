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
    public partial class LoginPage : Form
    {
        public  bool IsOpen { get; private set; }
        public LoginPage()
        {
            InitializeComponent();
            IsOpen = true;
            this.FormClosed += LoginPage_FormClosed;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            } else
            {
                PasswordTextBox.UseSystemPasswordChar= true;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
        //Checking if Login form is closed 
        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsOpen = false;
        }
    }
}
