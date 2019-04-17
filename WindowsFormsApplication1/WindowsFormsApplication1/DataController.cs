using System;

using System.IO;
using System.Collections;

public class DataController
{
    public static string user;
    public static bool isManager;
    public static int count;
    public static Reservation[] resArray = new Reservation[100];

	public DataController()
	{
	}
    public static void createReservation(int paymentInfo, int cost, int date, int room, String name, String type, String email)
    {
        Reservation newRes = new Reservation(paymentInfo, cost, date, room, name, type, email);
        resArray[count] = newRes;

    }
    public static Reservation searchReservation( String name)
    {
        for (int i=0; i<100; i++)
        {
            
            if (resArray[i].getName() == name)
            {
                return resArray[i];
            }
            

        }
        return null;
    }
    public static void cancleReservation(int index)
    {
        resArray[index] = null;
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
}
