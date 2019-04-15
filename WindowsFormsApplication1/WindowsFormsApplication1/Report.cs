
using System;

public class Report {
    private double baseRate;
    private short totalReservations;
    private short prepaidNum;
    private short sixtyDayNum;
    private short conventionalNum;
    private short incentiveNum;

    public Report() {
        baseRate = 100;
        totalReservations = 0;
        prepaidNum = 0;
        sixtyDayNum = 0;
        conventionalNum = 0;
        incentiveNum = 0;
    }

    public Report(Calendar[] dates, Reservation[] reservations, string s)
    {
        foreach (Calendar date in dates) {

        }

    }

    string expectedOccupancy()
    {
        return "this";
    }

    
}

