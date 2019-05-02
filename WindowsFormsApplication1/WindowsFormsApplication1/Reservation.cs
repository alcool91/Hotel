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
    string date, paymentInfo, name, phone, type, email, datePaid;   

    public Reservation(string paymentInfo, double cost, string date, int numNights, int room, string name, string phone, string type, string email, string datePaid)
    {
        this.paymentInfo = paymentInfo;
        this.cost = cost;
        this.date = date;
        this.numNights = numNights;
        this.room = room;
        this.name = name;
        this.phone = phone;
        this.type = type;
        if (this.type == "c" && DataController.calendar.getOccupancyRate(date, numNights) <= 0.6)  // Changes type to incentive if it's conventional and less than 60% occupied
            this.type = "i";
        this.email = email;
        this.datePaid = datePaid;
    }
    public Reservation(string paymentInfo, string cost, string date, string numNights, string room, string name, string phone, string type, string email, string datePaid)
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
        this.datePaid = datePaid;
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
    public string getName()
    {
        return name;
    }
    public string getType()
    {
        return type;
    }
    public string getEmail()
    {
        return email;
    }
    public string getPhone()
    {
        return phone;
    }
    public string getDatePaid()
    {
        return datePaid;
    }
    public void setRoom(int i)
    {
        room = i;
    }
    public void setDatePaid(string s)
    {
        datePaid = s;
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
    public void changeType(string NewType)
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


