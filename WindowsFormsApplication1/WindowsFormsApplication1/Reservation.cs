using System;
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

    public Reservation(string paymentInfo, double cost, string date, int numNights, int room, String name, String phone, String type, String email)
    {
        this.paymentInfo = paymentInfo;
        this.cost = cost;
        this.date = date;
        this.numNights = numNights;
        this.room = room;
        this.name = name;
        this.phone = phone;
        this.type = type;
        this.email = email;
    }
    public Reservation(string paymentInfo, string cost, string date, string numNights, string room, String name, String phone, String type, String email)
    {
        this.paymentInfo = paymentInfo;
        this.cost = double.Parse(cost);
        this.date = date;
        this.numNights = int.Parse(numNights);
        this.room = int.Parse(room);
        this.name = name;
        this.phone = phone;
        this.type = type;
        this.email = email;
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
    public String getPhone()
    {
        return phone;
    }
    public void setRoom(int i)
    {
        room = i;
    }
    public bool equals(Reservation r)
    {
        if (this.cost != r.getCost()) return false;
        if (this.name != r.getName()) return false;
        if (this.phone != r.getPhone()) return false;
        if (this.numNights != r.getNumNights()) return false;
        if (this.date != r.getStartDate()) return false;
        if (this.email != r.getEmail()) return false;
        if (this.type != r.getType()) return false;
        if (this.room != r.getRoom()) return false;
        if (this.paymentInfo != r.getPayment()) return false;
        return true;
    }
   


    // NOT DONE
    public void changeReservation(Reservation currentReservation, string newStart, int newNumNights, string type)
    {
        double currentCost = currentReservation.getCost();
        double newCost = 1.1 * DataController.calendar.getCost(newStart, newNumNights, type);

        DataController.calendar.subtractReservation(currentReservation.getStartDate(), currentReservation.getNumNights(), currentReservation.getType());

    }
    public void changeType(String NewType)
    {
        this.type = NewType;
    }
    public string toString()
    {
        string s;
        s = getPayment() + " " + getCost() + " " + getStartDate() + " " + getNumNights() + " " + getRoom() + " "
            + getName() + " " + getPhone() + " " + getType() + " " + getEmail();
        return s;
    }
}


