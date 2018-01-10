using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastPunch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  //
        {
            Application.EnableVisualStyles(); // enable visual elements for the application
            Application.SetCompatibleTextRenderingDefault(false); //Sets the application for the UseCompatibleTextRendering property defined on certain controls.
            Application.Run(new MainForm());
        }
    }
}
