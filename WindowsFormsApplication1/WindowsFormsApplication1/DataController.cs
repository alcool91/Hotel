using System;

using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System.Globalization;

public class DataController
{
    public static string user;
    public static bool isManager;
    public static int modIndex;
    public static int count;
    public static String PhoneNum, SearchName;
    public static Calendar calendar = new Calendar();
    public static List<Reservation> resList = new List<Reservation>();
    public static SortedDictionary<int, Reservation> rooms = new SortedDictionary<int, Reservation>();

    public DataController() {}

    // On program startup, loads in all reservations from file
    public static void importReservationsFromFile()
    {
        if (!File.Exists("../Reservations.txt"))            // Creates file if it doesn't yet exist
        {
            var newFile = File.Create("../Reservations.txt");
            newFile.Close();
        }
        StreamReader sr = new StreamReader("../Reservations.txt");
        long lineNum = 1;
        while (!sr.EndOfStream)
        {                              // As long as it's not end of stream,
            lineNum++;
            if (sr.ReadLine() == "#") // If there's a problem with file formatting, this gets it back on track
            {  
                createReservation(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), lineNum);
                lineNum += 9;
            }  
        }
        sr.Close();
    }

    public static void setupRooms()
    {
        foreach(Reservation r in resList)
        {
            if (r.getRoom() != 0)
            {
                rooms.Add(r.getRoom(), r);
            }
        }
        
        for (int j = 0; j < resList.Count; j++)
        {
            if (resList[j].getStartDate() == DateTime.Today.ToString("yyyyMMdd") && resList[j].getRoom() == 0)
            {
                int i = 1;
                Reservation value;
                while (rooms.TryGetValue(i, out value) && i < 46)
                {
                    i = i + 1;
                }


                value = new Reservation(resList[j].getPayment(), resList[j].getCost(), resList[j].getStartDate(), resList[j].getNumNights(), 
                    i, resList[j].getName(), resList[j].getPhone(), resList[j].getType(), resList[j].getEmail());
                modifyReservation(resList[j], value);
                rooms.Add(i, value);

            }
        }
        /*foreach (Reservation r in resList)
        {  
            if (r.getStartDate() == DateTime.Today.ToString("yyyyMMdd") && r.getRoom() == 0)
            {
                int i = 1;
                Reservation value;
                while(rooms.TryGetValue(i, out value) && i < 46)
                {
                    i = i + 1 ;
                }
                
                
                value = new Reservation(r.getPayment(), r.getCost(), r.getStartDate(), r.getNumNights(), i, r.getName(), r.getPhone(), r.getType(), r.getEmail());
                modifyReservation(r, value);
                rooms.Add(i, value);
                
            }
        }*/
    }

    public static void modifyReservation(Reservation r1, Reservation r2)
    {
        deleteFromFile(r1);
        writeReservation(r2);
        addToRecord("Modified Reservation: " + r1.toString() + " to " + r2.toString());
        resList.Remove(r1);
        resList.Add(r2);
    }

    public static void deleteFromFile(Reservation r)
    {
        StreamWriter sw = new StreamWriter("../tempReservations.txt");
        StreamReader sr = new StreamReader("../Reservations.txt");
        bool isDeleted = false;
        while (!sr.EndOfStream)   // As long as it's not end of stream,
        {                              
            if (!isDeleted && sr.Peek() == '#') // Keep looking for the matching reservation.
            {
                sr.ReadLine();
                Reservation compare = new Reservation(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
                if (r.equals(compare))
                {
                    isDeleted = true; // Doesn't print current reservation
                }
                else
                {
                    sw.WriteLine("#");
                    sw.WriteLine(compare.getPayment());
                    sw.WriteLine(compare.getCost());
                    sw.WriteLine(compare.getStartDate());
                    sw.WriteLine(compare.getNumNights());
                    sw.WriteLine(compare.getRoom());
                    sw.WriteLine(compare.getName());
                    sw.WriteLine(compare.getPhone());
                    sw.WriteLine(compare.getType());
                    sw.WriteLine(compare.getEmail());
                }
            }
            else
            {
                sw.WriteLine(sr.ReadLine()); // Writes the rest one line at a time
            }
            
        }
        sr.Close();
        sw.Close();
        File.Delete("../Reservations.txt");
        File.Move("../tempReservations.txt", "../Reservations.txt");
        File.Delete("../tempReservations.txt");
        calendar.removeReservation(r);
    }

    public static void writeReservation(Reservation r) // Writes reservation to end of file
    {
        StreamWriter sw = new StreamWriter("../Reservations.txt", true);
        sw.WriteLine("#");
        sw.WriteLine(r.getPayment());
        sw.WriteLine(r.getCost());
        sw.WriteLine(r.getStartDate());
        sw.WriteLine(r.getNumNights());
        sw.WriteLine(r.getRoom());
        sw.WriteLine(r.getName());
        sw.WriteLine(r.getPhone());
        sw.WriteLine(r.getType());
        sw.WriteLine(r.getEmail());
        sw.Close();
        calendar.addReservation(r);
    }

    public static void createReservation(string paymentInfo, double cost, string date, int numNights, int room, string name,  string phone, string type, string email)
    {
        Reservation newRes = new Reservation(paymentInfo, cost, date, numNights, room, name, phone, type, email);
        resList.Add(newRes);
        writeReservation(newRes);
        addToRecord("Created Reservation: " + newRes.toString());     
    }

    public static void createReservation(string paymentInfo, string cost, string date, string numNights, string room, string name, string phone, string type, string email, long lineNum)
    {
        if (paymentInfo == "#" || cost == "#" || date == "#" || numNights == "#" || room == "#" // Makes sure importing from file doesn't have an obvious issue
            || name == "#" || phone == "#" || type == "#" || email == "#")
        {
            addToRecord("Encountered an error creating a reservation from file. Check line " + lineNum);
        }
        else
        {
            Reservation newRes = new Reservation(paymentInfo, cost, date, numNights, room, name, phone, type, email);
            resList.Add(newRes);
            if (lineNum == 0) // If this isn't a loaded in reservation, write creation to file
            {
                writeReservation(newRes);
                addToRecord("Created Reservation: " + newRes.toString());
            }
        } 

    }
    public static void storeIndex(int x)
    {
        modIndex = x;
    }
    public static void modReservation(int index, Reservation X)
    {
        resList[index] = X;
    }
    public static void addToRecord(string s)
    {
        StreamWriter sw = new StreamWriter("../recordData.txt", true);
        sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss ") + s);
        sw.Close();
    }

    public static int searchReservation(String name,int index)
    {
        if(index == -1)
        {
            index = 0;
        }
        for (int i = index; i<resList.Count; i++)
        {
            
            if (resList[i].getName().ToUpper() == name.ToUpper())
            {
                index = i;
                return index;
            }
            

        }
        return -1;
    }

    public static void cancelReservation(int index)
    {
        resList.Remove(resList[index]);

    }

    public static void getSearchInfo(String name, String Phone)
    {
        PhoneNum = Phone;
        SearchName = name;
    }

    public static String setSearchNum()
    {
        return PhoneNum;
    }

    public static String setSearchName()
    {
        return SearchName;
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

    public static bool checkManager(string userName, string password)
    {
        using (StreamReader sr = new StreamReader("../../Users.txt"))
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
                        //user = userName;
                        if (Convert.ToBoolean(tokens[2])) { return true; };
                        return false;
                    }
                }
            } while ((line = sr.ReadLine()) != null);
            return false;
        }
    }

    
}
