using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<<< HEAD:TestIconicPizza/TestIconicPizza/Program.cs
namespace TestIconicPizza
========
namespace TrevysIconicPizza
>>>>>>>> main:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/Program.cs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<<< HEAD:TestIconicPizza/TestIconicPizza/Program.cs
            Application.Run(new LandingPage());
========
            Application.Run(new MenuPage());

>>>>>>>> main:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/Program.cs
        }
    }
}
