﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Date
{
    double baseRate;
    short totalReservations;
    short prepaidNum;
    short sixtyDayNum;
    short conventionalNum;
    short incentiveNum;

    public Date()
    {
        baseRate = 600;
        totalReservations = 0;
        prepaidNum = 0;
        sixtyDayNum = 0;
        conventionalNum = 0;
        incentiveNum = 0;
    }

    public Date(double b)
    {
        baseRate = b;
        totalReservations = 0;
        prepaidNum = 0;
        sixtyDayNum = 0;
        conventionalNum = 0;
        incentiveNum = 0;
    }

    public Date(double b, short t, short p, short s, short c, short i)
    {
        baseRate = b;
        totalReservations = t;
        prepaidNum = p;
        sixtyDayNum = s;
        conventionalNum = c;
        incentiveNum = i;
    }

    public Date(string s)
    {
        baseRate = double.Parse(s.Substring(0, s.IndexOf(" ")));
        s = s.Substring(s.IndexOf(" "), s.Length - s.IndexOf(" "));
        s = s.TrimStart();

        totalReservations = short.Parse(s.Substring(0, s.IndexOf(" ")));
        s = s.Substring(s.IndexOf(" "), s.Length - s.IndexOf(" "));
        s = s.TrimStart();

        prepaidNum = short.Parse(s.Substring(0, s.IndexOf(" ")));
        s = s.Substring(s.IndexOf(" "), s.Length - s.IndexOf(" "));
        s = s.TrimStart();

        sixtyDayNum = short.Parse(s.Substring(0, s.IndexOf(" ")));
        s = s.Substring(s.IndexOf(" "), s.Length - s.IndexOf(" "));
        s = s.TrimStart();

        conventionalNum = short.Parse(s.Substring(0, s.IndexOf(" ")));
        s = s.Substring(s.IndexOf(" "), s.Length - s.IndexOf(" "));
        s = s.TrimStart();

        incentiveNum = short.Parse(s);

    }

    /*public ~Date() {
        baseRate = 0;
        totalReservations = 0;
        prepaidNum = 0;
        sixtyDayNum = 0;
        conventionalNum = 0;
        incentiveNum = 0;
    }*/

    public double getRate() { return baseRate; }
    public void setRate(double d) { baseRate = d; }

    public void addType(string t)
    {
        switch (t)
        {
            case "p":
                addPrepaid();
                break;
            case "s":
                addSixty();
                break;
            case "c":
                addConventional();
                break;
            case "i":
                addIncentive();
                break;
        }
            
    }
    public void addPrepaid()
    {
        prepaidNum++;
        totalReservations++;
    }
    public void addSixty()
    {
        sixtyDayNum++;
        totalReservations++;
    }
    public void addConventional()
    {
        conventionalNum++;
        totalReservations++;
    }
    public void addIncentive()
    {
        incentiveNum++;
        totalReservations++;
    }

    public void removeType(string t)
    {
        switch (t)
        {
            case "p":
                removePrepaid();
                break;
            case "s":
                removeSixty();
                break;
            case "c":
                removeConventional();
                break;
            case "i":
                removeIncentive();
                break;
        }

    }
    public void removePrepaid()
    {
        prepaidNum--;
        totalReservations--;
    }
    public void removeSixty()
    {
        sixtyDayNum--;
        totalReservations--;
    }
    public void removeConventional()
    {
        conventionalNum--;
        totalReservations--;
    }
    public void removeIncentive()
    {
        incentiveNum--;
        totalReservations--;
    }

    public short getPrepaid()
    {
        return prepaidNum;
    }
    public short getSixty()
    {
        return sixtyDayNum;
    }
    public short getConventional()
    {
        return conventionalNum;
    }
    public short getIncentive()
    {
        return incentiveNum;
    }
    public short getTotal()
    {
        return totalReservations;
    }
    public string toString()
    {
        string s;
        s = baseRate + " " + totalReservations + " " + prepaidNum + " " + sixtyDayNum + " " + conventionalNum + " " + incentiveNum;
        return s;
    }
}
