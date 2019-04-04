using System;
using System.IO;
using System.Collections;

public class DataController
{
    public string user;
    public bool isManager;
	public DataController()
	{
	}
    public static bool autenticateUser(string userName, string password)
    {
        using(StreamReader sr = new StreamReader("users.txt"))
        {
            string line;
            string[] tokens;
            do
            {
                line = sr.ReadLine();
                tokens = line.Split('\t');
                if (tokens[0] == userName)
                {
                    Console.WriteLine("User Matched!");
                    if (tokens[1] == password)
                    {
                        Console.WriteLine("User Authenticated! Welcome " + userName);
                        this.user = userName;
                        this.isManager = (bool)tokens[2];
                        return true;
                    }
                }
            } while (line = sr.ReadLine() != null);
            return false;
        }
    }
}
