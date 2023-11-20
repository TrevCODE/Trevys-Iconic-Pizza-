using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestIconicPizza
{
<<<<<<<< HEAD:TestIconicPizza/TestIconicPizza/LandingPage.cs
    public partial class LandingPage : Form
    {
        public LandingPage()
========
    public partial class DrinkPage : Form
    {
        public DrinkPage()
>>>>>>>> main:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/DrinkPage.cs
        {
            InitializeComponent();

            drinkPanel.AutoScrollMinSize = new Size(0, 580);
            this.Size = new Size(Width, Height + 10);
        }

    }
}
