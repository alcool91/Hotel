using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class DataController
{
    public static string user;
    public static bool isManager;
	public DataController()
	{
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

    public static void getReservations(SortedDictionary<string, Reservation> &a)
    {
        ;
    }
}
