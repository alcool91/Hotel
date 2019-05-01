
using System;
using System.Globalization;

public class Report {
    static string output;


    public Report() {
        output = "";
    }

    //public Report(Date[] dates, Reservation[] reservations, string s)
    //{
    //if(s == "expectedOccupancy")
    //{
    //expectedOccupancy();
    //}


    //}

    public static string getExpectedOccupancy(string startDate, int numNights)
    {
        //DateTime currentDate;
        double average = 0;
        string output = "";
        output += "Date\tPrepaid\tSixty Day\tConventional\tIncentive";
        for (int i = 0; i < numNights; i++)
        {  // Gets data for each day for next 30 days
            Date d = DataController.calendar.getDate(DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("yyyyMMdd"));
            average += d.getTotal();
            output += "\n" + DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("MM/dd/yyyy") + "\t" + d.getPrepaid() + "\t" + d.getSixty()
                + "\t" + d.getConventional() + "\t" + d.getIncentive() + "\t" + d.getTotal() + "\n";
            //DateTime.TryParse(output,out currentDate);
        }
        output += "Average expected occupancy: " + 100 * DataController.calendar.getOccupancyRate(startDate, numNights) + "%";
        return output;
    }

    public static string getExpectedIncome(Reservation[] reservations)
    {
        return "";
    }

    
}

