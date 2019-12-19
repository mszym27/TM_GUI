using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var gui = new GUI();

            gui.addTapeElement("a");
            gui.addTapeElement("a");
            gui.addTapeElement("b");
            gui.addTapeElement("a");

            Application.Run(gui);
        }
    }
}
