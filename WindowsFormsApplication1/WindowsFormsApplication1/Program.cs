using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net.Mail;


namespace WindowsFormsApplication1
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.IO.Directory.CreateDirectory(".\\Hotel\\Storage");
            System.IO.Directory.CreateDirectory(".\\Hotel\\Reports");
            DataController.calendar.importFromFile();
            DataController.importReservationsFromFile();
            DataController.setupRooms();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
        }
    }
}
