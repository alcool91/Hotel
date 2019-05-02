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
            //DataController.
            DataController.calendar.importFromFile();
            /*DataController.calendar.addDate("20190523");
            DataController.calendar.addDate("20190524", 595.5);
            DataController.calendar.addDate("20190525");
            DataController.calendar.addDate("20190525", 650.49);
            DataController.calendar.addDate("20190526", "312.47 45 0 15 15 15");
            DataController.calendar.setRates("20190527", 30, 622);*/
            DataController.importReservationsFromFile();
            DataController.setupRooms();
            //DataController.createReservation("paymentinfo", "12345.5", "20190824", "3", "0", "Brent W", "734...", "p", "brentme1@yahoc.com", 0);
            //string p = Report.getExpectedOccupancy("20190501", 30);
            //string q = Report.getExpectedIncome();
            //DataController.deleteFromFile(DataController.resList[0]);
            
            //Console.WriteLine(DataController.calendar.getOccupancyRate(DateTime.ParseExact("20190527", "yyyyMMdd", CultureInfo.InvariantCulture), 30));
            //string test = DataController.calendar.areDatesaAvailable("20190527", 10);
            //double p = DataController.calendar.getOccupancyRate("20190527", 30);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Login login = new Login();
            Application.Run(new Login());
            
        }
    }
}
