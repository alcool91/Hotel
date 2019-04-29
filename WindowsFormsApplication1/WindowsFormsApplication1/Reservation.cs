﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
public class Reservation
{
    double cost;
    int room, numNights;
    String date, paymentInfo, name, phone, type, email;

    public Reservation(string paymentInfo, double cost, string date, int room, String name, String phone,String type, String email)
    {
        this.paymentInfo = paymentInfo;
        this.cost = cost;
        this.date = date;
        this.room = room;
        this.name = name;
        this.type = type;
        this.email = email;
        this.phone = phone;



    }

    public int getNumNights() { return numNights; }
    public string getPayment()
    {
        return paymentInfo;
    }
    public double getCost()
    {
        return cost;
    }
    public string getStartDate()
    {
        return date;
    }
    public int getRoom()
    {
        return room;
    }
    public String getName()
    {
        return name;
    }
    public String getType()
    {
        return type;
    }
    public String getEmail()
    {
        return email;
    }

    // NOT DONE
    public void changeReservation(Reservation currentReservation, string newStart, int newNumNights, string type)
    {
        double currentCost = currentReservation.getCost();

        DataController.calendar.subtractReservation(DateTime.ParseExact(currentReservation.getStartDate(), "yyyyMMdd", CultureInfo.InvariantCulture), currentReservation.getNumNights(), currentReservation.getType());

    }
    public void changeType(String NewType)
    {
        this.type = NewType;
    }
    public string toString()
    {
        string s;
        s = name + " " + date + " " + type + " " + cost + " " + room + " " + email;
        return s;
    }
}


