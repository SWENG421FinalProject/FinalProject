using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWENG421GUI;
using SWENG421GUI.Vehicles;
using SWENG421GUI.States;
using System.Threading;

namespace SWENG421GUI
{

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //Run Program
            //Multiple threads start
            //Company assigns routes
            //Vehicles goes on routes
            //Order state changes


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
