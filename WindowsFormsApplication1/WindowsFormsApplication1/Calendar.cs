using System;

public class Calendar {
    private double baseRate;
    private short totalReservations;
    private short prepaidNum;
    private short sixtyDayNum;
    private short conventionalNum;
    private short incentiveNum;

    public Calendar() {
        baseRate = 100;
        totalReservations = 0;
        prepaidNum = 0;
        sixtyDayNum = 0;
        conventionalNum = 0;
        incentiveNum = 0;
    }

    public Calendar(double b, short t, short p, short s, short c, short i) {
        baseRate = b;
        totalReservations = t;
        prepaidNum = p;
        sixtyDayNum = s;
        conventionalNum = c;
        incentiveNum = i;
    }

    /*public ~Calendar() {
        baseRate = 0;
        totalReservations = 0;
        prepaidNum = 0;
        sixtyDayNum = 0;
        conventionalNum = 0;
        incentiveNum = 0;
    }*/

    public double getRate() { return baseRate; }

    public void setRate(double d) { baseRate = d; }

    public void addPrepaid() {
        prepaidNum++;
        totalReservations++;
    }
    public void addSixty() {
        sixtyDayNum++;
        totalReservations++;
    }
    public void addConventional() {
        conventionalNum++;
        totalReservations++;
    }
    public void addIncentive() {
        incentiveNum++;
        totalReservations++;
    }

    public void removePrepaid() {
        prepaidNum--;
        totalReservations--;
    }
    public void removeSixty() {
        sixtyDayNum--;
        totalReservations--;
    }
    public void removeConventional() {
        conventionalNum--;
        totalReservations--;
    }
    public void removeIncentive() {
        incentiveNum--;
        totalReservations--;
    }
}

