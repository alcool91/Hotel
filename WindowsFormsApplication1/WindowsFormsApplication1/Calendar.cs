
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

public class Calendar {
    private static SortedList<string, Date> dates = new SortedList<string, Date>();
    public static SortedList<string, double> reservationFactor = new SortedList<string, double>();
    const int TOTALROOMS = 45;

    public Calendar()
    {
        reservationFactor.Add("p", 0.75);   // Prepaid reservation factor
        reservationFactor.Add("s", 0.85);   // Sixty-day reservation factor
        reservationFactor.Add("c", 1.00);   // Conventional reservation factor
        reservationFactor.Add("i", 0.80);   // Prepaid reservation factor
    }

    public void addReservation(Reservation r)
    {
        for(int i = 0; i < r.getNumNights(); i++)
        {
            getDate(DateTime.ParseExact(r.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("yyyyMMdd")).addType(r.getType());
            updateFile(DateTime.ParseExact(r.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("yyyyMMdd"));
        }
    }

    public void removeReservation(Reservation r)
    {
        for (int i = 0; i < r.getNumNights(); i++)
        {
            getDate(DateTime.ParseExact(r.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("yyyyMMdd")).removeType(r.getType());
            updateFile(DateTime.ParseExact(r.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("yyyyMMdd"));
        }
    }

    public Date getDate(string date)
    {
        Date value;
        if (dates.TryGetValue(date, out value))
        {
            return value;
        }
        else
        {
            addDate(date);
            return dates[date];
        }         
    }

    public void addDate(string date)
    {
        Date value;
        if(dates.TryGetValue(date, out value))
        {
            return;                     // If date already exists, do nothing
        }
        else
        {
            dates.Add(date, new Date());   // Otherwise, create a new date and add to dates
        }
        //updateFile(date);
    }

    public void addDate(string date, double rate)
    {
        Date value;
        if (dates.TryGetValue(date, out value))
        {
            value.setRate(rate);           // If date already exists, change the base rate
        }
        else
        {
            dates.Add(date, new Date(rate));  // Otherwise, create a new date and add to dates
        }
        updateFile(date);
    }  

    public void addDate(string date, string content) // Should only be called at beginning of program when importing all dates
    {
        Date value;
        if (dates.TryGetValue(date, out value))
        {
            dates.Remove(date);                                                                 // If date already exists, delete it
        }
        dates.Add(date, new Date(content));
        updateFile(date);
    }

    /*public void addDate(string date, double baseRate, short total, short prepaid, short sixty, short conventional, short incentive)
    {
        if (dates.TryGetValue(date, out Date value))
        {
            dates.Remove(date);                                                                 // If date already exists, delete it
        }
        dates.Add(date, new Date(baseRate, total, prepaid, sixty, conventional, incentive));    // Create and add new date
        updateFile(date);
    }
    */

    public void importFromFile()
    {
        string entireLine;
        string date;
        if (!File.Exists("../Calendar.txt"))
        {
            var newFile = File.Create("../Calendar.txt");
            newFile.Close();
        }
        StreamReader sr = new StreamReader("../Calendar.txt");
        while (!sr.EndOfStream) {                              // As long as it's not end of stream, 
            entireLine = sr.ReadLine();                             // Add dates one line at a time
            date = entireLine.Substring(0, entireLine.IndexOf(' '));
            entireLine = entireLine.Substring(date.Length + 1, entireLine.Length - (date.Length + 1));
            if(DateTime.ParseExact(date, "yyyyMMdd", CultureInfo.InvariantCulture) >= DateTime.Today) // Only adds dates >= today's date
                dates.Add(date, new Date(entireLine));
        }       
        sr.Close();
    }

    public void updateFile(string newDate)
    {
        StreamReader sr = new StreamReader("../Calendar.txt");
        StreamWriter sw = new StreamWriter("../tempCalendar.txt");
        bool newDateWritten = false;
        while (!sr.EndOfStream)
        {
            string currentLine = sr.ReadLine();
           
            if (!newDateWritten) {
                string currentDate = currentLine.Substring(0, currentLine.IndexOf(' '));
                if (DateTime.ParseExact(currentDate, "yyyyMMdd", CultureInfo.InvariantCulture) < DateTime.Today)
                {

                }
                else if (currentDate == newDate)
                {
                    currentLine = newDate + " " + getDate(newDate).toString();
                    sw.WriteLine(currentLine);
                    newDateWritten = true;
                }
                else if (Int32.Parse(newDate) < Int32.Parse(currentDate))
                {
                    sw.WriteLine(newDate + " " + getDate(newDate).toString());
                    sw.WriteLine(currentLine);
                    newDateWritten = true;
                }
                else
                {
                    sw.WriteLine(currentLine);
                }
            }
            else
            {
                sw.WriteLine(currentLine);
            }   
        }
        if (!newDateWritten)
        {
            sw.WriteLine(newDate + " " + getDate(newDate).toString());
        }
        sw.Close();
        sr.Close();
        
        File.Delete("../Calendar.txt");
        File.Move("../tempCalendar.txt", "../Calendar.txt");
        File.Delete("../tempCalendar.txt");
    }

    public double getCost(string startDate, int numNights, string type)
    {
        DateTime thisDate = DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture);
        // Changes conventional to incentive if occupancy rate < 0.6 and start is less than 30 days away
        if (thisDate < DateTime.Today.AddDays(30) && type == "c" && getOccupancyRate(startDate, numNights) <= 0.6) type = "i"; 


        double cost = 0;
        for (int i = 0; i < numNights; i++)  // Adds price of each night together times the reservation type
        {
            cost += reservationFactor[type] * getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).getRate();
        }
        return cost;
    }

    // Returns occupancy rate as a decimal between 0 and 1 for a range of dates
    public double getOccupancyRate(string startDate, int numNights)
    {
        DateTime thisDate = DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture);
        double occupancyRate;
        int occupancy = 0;
        
        for (int i = 0; i < numNights; i++)
        {
            occupancy += getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).getTotal();
        }
        occupancyRate = (double)occupancy / ((double)numNights * (double)TOTALROOMS);
        return occupancyRate;
    }

    // Sets rates for a range of dates
    public void setRates(string startDate, int numNights, double rate)
    {
        DateTime thisDate = DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture);
        for(int i = 0; i < numNights; i++)
        {
            addDate(thisDate.AddDays(i).ToString("yyyyMMdd"), rate);
        }
    }

    // Adds to the reservation count for a range of dates with certain reservation type
    public void addReservation(string startDate, int numNights, string type)
    {
        DateTime thisDate = DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture);
        // Changes conventional to incentive if occupancy rate < 0.6 and start is less than 30 days away
        if (thisDate < DateTime.Today.AddDays(30) && type == "c" && getOccupancyRate(startDate, numNights) <= 0.6) type = "i";

        for (int i = 0; i < numNights; i++)
        {
            if (type == "p") getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).addPrepaid();
            else if (type == "s") getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).addSixty();
            else if (type == "c") getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).addConventional();
            else if (type == "i") getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).addIncentive();
            updateFile(thisDate.AddDays(i).ToString("yyyyMMdd"));
        }
    }

    // Subtracts from the reservation count for a range of dates with certain reservation type
    public void subtractReservation(string startDate, int numNights, string type)
    {
        DateTime thisDate = DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture);
        // Changes conventional to incentive if occupancy rate < 0.6 and start is less than 30 days away
        //if (startDate < DateTime.Today.AddDays(30) && type == "c" && getOccupancyRate(startDate, numNights) < 0.6) type = "i";

        for (int i = 0; i < numNights; i++)
        {
            if (type == "p") getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).removePrepaid();
            else if (type == "s") getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).removeSixty();
            else if (type == "c") getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).removeConventional();
            else if (type == "i") getDate(thisDate.AddDays(i).ToString("yyyyMMdd")).removeIncentive();
            updateFile(thisDate.AddDays(i).ToString("yyyyMMdd"));
        }
    }

    public string areDatesaAvailable(string startDate, int numNights)
    {
        string returnValue = "";
        for(int i = 0; i < numNights; i++)
        {
            if(getDate(DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("yyyyMMdd")).getTotal() >= 45)
            {
                returnValue += DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture).AddDays(i).ToString("MM/dd/yyyy ");
            }
        }
        if(returnValue == "")
        {
            return returnValue;
        }
        else
        {
            return "The following dates unavailable: " + returnValue;
        }       
    }
}
