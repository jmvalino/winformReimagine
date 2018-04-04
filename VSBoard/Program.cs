using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VSBoard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
           if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
           {

               MessageBox.Show("Application Board already running. Only one instance of this application is allowed");
               return;
           }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Maintainance.Maintain());
        }
    }
}
