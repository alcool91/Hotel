
using System;
using System.Globalization;
using System.IO;

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

    public static void getExpectedOccupancy(string startDate, int numNights)
    {
        StreamWriter sw = new StreamWriter(".\\Hotel\\Reports\\ExpectedOccupancy.txt");
        double average = 0;
        sw.WriteLine("Date\t\tPrepaid\t\tSixty Day\tConventional\tIncentive\tTotal");
        for (int i = 0; i < numNights; i++)
        {  // Gets data for each day for next 30 days
            Date d = DataController.calendar.getDate(DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("yyyyMMdd"));
            average += d.getTotal();
            sw.WriteLine(DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("MM/dd/yyyy") + "\t" + d.getPrepaid() + "\t\t" + d.getSixty()
                + "\t\t" + d.getConventional() + "\t\t" + d.getIncentive() + "\t\t" + d.getTotal());
        }
        sw.WriteLine("Average expected occupancy: " + string.Format("{0:.###}", 100 * DataController.calendar.getOccupancyRate(startDate, numNights))  + "%");
        sw.Close();
    }

    public static void getExpectedIncome()
    {
        StreamWriter sw = new StreamWriter(".\\Hotel\\Reports\\ExpectedIncome.txt");
        DateTime today = DateTime.Today;
        DateTime lastDay = today.AddDays(30);
        sw.WriteLine("Expected Income:");
        double[] nights = new double[30];
        double total = 0;
        for(int i = 0; i < 30; i++)
        {
            Date currentDay = DataController.calendar.getDate(today.AddDays(i).ToString("yyyyMMdd"));
            double rate = currentDay.getRate();
            nights[i] = currentDay.getRate() * (0.75 * currentDay.getPrepaid() + 0.85 * currentDay.getSixty() + 0.8 * currentDay.getIncentive() + currentDay.getConventional());
            total += nights[i];
            sw.WriteLine(today.AddDays(i).ToString("MM/dd/yyyy") + ":\t" + nights[i]);
        }
        sw.WriteLine("Total expected income over next 30 days: " + total);
        sw.Close();
    }

    public static void getIncentives()
    {
        StreamWriter sw = new StreamWriter(".\\Hotel\\Reports\\Incentives.txt");
        //int incentives = 0;
        double average = 0;
        sw.WriteLine("Incentive discount for each night:");
        for (int i = 0; i < 30; i++)
        {  // Gets data for each day for next 30 days
            Date d = DataController.calendar.getDate(DateTime.Today.AddDays(i).ToString("yyyyMMdd"));
            average += d.getIncentive() * .2 * d.getRate();
            sw.WriteLine(DateTime.Today.AddDays(i).ToString("MM/dd/yyyy") + "\t" + d.getIncentive() * .2 * d.getRate());
        }
        sw.WriteLine("Total incentive discount for next 30 nights: " + string.Format("{0:.###}", average));
        average = average / 30;
        sw.WriteLine("Average incentive discount: " + string.Format("{0:.###}", average) + " per night");
        sw.Close();
    }

    
}

