
using System;
using System.Collections.Generic;
public class Calendar {
    private static SortedList<string, Date> dates = new SortedList<string, Date>();
    public static SortedList<string, double> reservationFactor = new SortedList<string, double>();

    public Calendar()
    {
        reservationFactor.Add("p", 0.75);   // Prepaid reservation factor
        reservationFactor.Add("s", 0.85);   // Sixty-day reservation factor
        reservationFactor.Add("c", 1.00);   // Conventional reservation factor
        reservationFactor.Add("i", 0.80);   // Prepaid reservation factor
    }

    public Date getDate(string s)
    {
        if (dates.TryGetValue(s, out Date value))
        {
            return value;
        }
        else
        {
            addDate(s);
            return dates[s];
        }         
    }

    public void addDate(string s)
    {
        if(dates.TryGetValue(s, out Date value))
        {
            return;                     // If date already exists, do nothing
        }
        else
        {
            dates.Add(s, new Date());   // Otherwise, create a new date and add to dates
        }      
    }

    public void addDate(string s, double b)
    {
        if (dates.TryGetValue(s, out Date value))
        {
            value.setRate(b);           // If date already exists, change the base rate
        }
        else
        {
            dates.Add(s, new Date(b));  // Otherwise, create a new date and add to dates
        }      
    }

    public void addDate(string date, double baseRate, short total, short prepaid, short sixty, short conventional, short incentive)
    {
        if (dates.TryGetValue(date, out Date value))
        {
            dates.Remove(date);                                                                 // If date already exists, delete it
        }
        dates.Add(date, new Date(baseRate, total, prepaid, sixty, conventional, incentive));    // Create and add new date
    }

    public double getCost(DateTime startDate, int numNights, string type)
    {
        double cost = 0;
        for (int i = 0; i < numNights; i++)                  // Adds price of each night together times the reservation type
        {
            cost += reservationFactor[type] * getDate(startDate.AddDays(i).ToString("yyyyMMdd")).getRate();
        }
        return cost;
    }
}
