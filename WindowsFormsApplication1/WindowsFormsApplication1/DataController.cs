using System;

using System.IO;
using System.Collections;
using System.Collections.Generic;

public class DataController
{
    public static string user;
    public static bool isManager;
    public static int count;
    public static List<Reservation> resList = new List<Reservation>();
    public static SortedList<int, Calendar> dateList = new SortedList<int, Calendar>();

	public DataController()
	{
	}
    public static void createReservation(int paymentInfo, int cost, int date, int room, String name, String type, String email)
    {
        resList.Add(new Reservation(paymentInfo, cost, date, room, name, type, email));
    }
    public static void addDate(int date, double baseRate, short total, short prepaid, short sixty, short conventional, short incentive)
    {
        dateList.Add(date, new Calendar(date, baseRate, total, prepaid, sixty, conventional, incentive));
    }
    
    public static Reservation searchReservation( String name)
    {
        for (int i=0; i<100; i++)
        {
            
            if (resList[i].getName() == name)
            {
                return resList[i];
            }
            

        }
        return null;
    }
    public static void cancelReservation(Reservation r)
    {
        dateList[r.getDate()].removeFromReservation(r);
        resList.Remove(r);
    }

    public static bool authenticateUser(string userName, string password)
    {
        using(StreamReader sr = new StreamReader("../../Users.txt"))
        {
            string line;
            string[] tokens;
            line = sr.ReadLine();
            do
            {
                tokens = line.Split('\t');
                if (tokens[0] == userName)
                {
                    Console.WriteLine("User Matched!");
                    if (tokens[1] == password)
                    {
                        Console.WriteLine("User Authenticated! Welcome " + userName);
                        user = userName;
                        isManager = Convert.ToBoolean(tokens[2]);
                        return true;
                    }
                }
            } while ((line = sr.ReadLine()) != null);
            return false;
        }
    }

    //public static void getReservations(SortedDictionary<string, Reservation> &a)
    //{
        //;
    //}
}
