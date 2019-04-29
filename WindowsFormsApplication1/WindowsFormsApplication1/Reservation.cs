using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
public class Reservation
{
    double cost;
    int room, numNights;
    String date, phone, paymentInfo, name, type, email;

    public Reservation(string paymentInfo, double cost, string date, int room, String name, String type, String email)
    {
        this.paymentInfo = paymentInfo;
        this.cost = cost;
        this.date = date;
        this.room = room;
        this.name = name;
        this.type = type;
        this.email = email;

    }

    public string getPayment()
    {
        return paymentInfo;
    }
    public double getCost()
    {
        return cost;
    }
    public int getDate()
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


