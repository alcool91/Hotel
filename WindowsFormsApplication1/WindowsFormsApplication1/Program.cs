using System;
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

            DataController.createReservation(23423, 200, 20191220, 0, "Wick", "incentive", "mail@mail.mail");
            DataController.createReservation(233, 100, 20191221, 1, "Stamm", "conventional", "mail2@mail.mail");
            Console.WriteLine(DataController.resList);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Login login = new Login();
            Application.Run(new Login());
            
        }
    }
}
