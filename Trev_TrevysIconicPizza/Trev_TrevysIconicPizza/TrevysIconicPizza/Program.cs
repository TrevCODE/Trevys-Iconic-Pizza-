using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrevysIconicPizza
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
<<<<<<<< HEAD:CevsVersion_TrevysIconicPizza/TrevysIconicPizza/TrevysIconicPizza/Program.cs
            Application.Run(new MenuPage());

========
            Application.Run(new LandingPage());
>>>>>>>> origin/TrevBranch2:Trev_TrevysIconicPizza/Trev_TrevysIconicPizza/TrevysIconicPizza/Program.cs
        }
    }
}
