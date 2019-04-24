﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    class Program
    {
        SortedDictionary<string, Reservation> reservations;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DataController.
            DataController.addToRecord("Testing a new line");
            DataController.addToRecord("Testing another new line");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Login login = new Login();
            Application.Run(new Login());
            
        }
    }
}
