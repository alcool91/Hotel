
using System;

public class Report {
    string output;


    public Report() {
        output = "";
    }

    //public Report(Calendar[] dates, Reservation[] reservations, string s)
    //{
        //if(s == "expectedOccupancy")
        //{
            //expectedOccupancy();
        //}


    //}

    string getExpectedOccupancy(Calendar[] dates)
    {
        DateTime currentDate;
        double average = 0;
        output = "";
        output += "Date\tPrepaid\tSixty Day\tConventional\tIncentive\n";
        for (int i = 1; i < 31; i++)
        {  // Gets data for each day for next 30 days
            average += dates[i].getTotal();
            output += DateTime.Now.ToString("yyyyMMdd") + "\t" + dates[i].getPrepaid() + "\t" + dates[i].getSixty()
                + "\t" + dates[i].getConventional() + "\t" + dates[i].getIncentive() + "\t" + dates[i].getTotal() + "\n";
            DateTime.TryParse(output,out currentDate);
        }
        output += "Average expected occupancy: " + 100 * (average / 30) + "%";
        return output;
    }

    string getExpectedIncome(Reservation[] reservations)
    {
        return "";
    }

    
}

