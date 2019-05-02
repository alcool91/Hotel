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
        if (!File.Exists(".\\Hotel\\Storage\\Reservations.txt"))            // Creates file if it doesn't yet exist
        {
            var newFile = File.Create(".\\Hotel\\Storage\\Reservations.txt");
            newFile.Close();
        }
        StreamReader sr = new StreamReader(".\\Hotel\\Storage\\Reservations.txt");
        long lineNum = 1;
        while (!sr.EndOfStream)
        {                              // As long as it's not end of stream,
            lineNum++;
            if (sr.ReadLine() == "#") // If there's a problem with file formatting, this gets it back on track
            {  
                createReservation(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), lineNum);
                lineNum += 10;
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
    }

    public static int assignRoom(Reservation r)
    {
        int i = 1;
        while (i < 46)
        {
            Reservation value;
            if(!rooms.TryGetValue(i, out value))
            {
                value = new Reservation(r.getPayment(), r.getCost(), r.getStartDate(), r.getNumNights(),
                    i, r.getName(), r.getPhone(), r.getType(), r.getEmail(), r.getDatePaid());
                modifyReservation(r, value);
                rooms.Add(i, r);
                return i;
            }
            else
            {
                i++;
            }
        }
        return 0;
    }

    public static void checkOut(int room, Reservation r)
    {
        rooms.Remove(room);
        deleteFromFile(r);
        addToRecord("Checked Out Reservation: " + r.toString());
        resList.Remove(r);
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
        StreamWriter sw = new StreamWriter(".\\Hotel\\Storage\\tempReservations.txt");
        StreamReader sr = new StreamReader(".\\Hotel\\Storage\\Reservations.txt");
        bool isDeleted = false;
        while (!sr.EndOfStream)   // As long as it's not end of stream,
        {                              
            if (!isDeleted && sr.Peek() == '#') // Keep looking for the matching reservation.
            {
                sr.ReadLine();
                Reservation compare = new Reservation(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
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
                    sw.WriteLine(compare.getDatePaid());
                }
            }
            else
            {
                sw.WriteLine(sr.ReadLine()); // Writes the rest one line at a time
            }
            
        }
        sr.Close();
        sw.Close();
        File.Delete(".\\Hotel\\Storage\\Reservations.txt");
        File.Move(".\\Hotel\\Storage\\tempReservations.txt", ".\\Hotel\\Storage\\Reservations.txt");
        File.Delete(".\\Hotel\\Storage\\tempReservations.txt");
        calendar.removeReservation(r);
    }

    public static void writeReservation(Reservation r) // Writes reservation to end of file
    {
        StreamWriter sw = new StreamWriter(".\\Hotel\\Storage\\Reservations.txt", true);
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
        sw.WriteLine(r.getDatePaid());
        sw.Close();
        calendar.addReservation(r);
    }

    public static void createReservation(string paymentInfo, double cost, string date, int numNights, int room, string name,  string phone, string type, string email, string datePaid)
    {
        if (type == "c" && calendar.getOccupancyRate(date, numNights) <= 0.6)  // Changes type to incentive if it's conventional and less than 60% occupied
            type = "i";
        Reservation newRes = new Reservation(paymentInfo, cost, date, numNights, room, name, phone, type, email, datePaid);
        resList.Add(newRes);
        writeReservation(newRes);
        addToRecord("Created Reservation: " + newRes.toString());     
    }

    public static void createReservation(string paymentInfo, string cost, string date, string numNights, string room, string name, string phone, string type, string email, string datePaid, long lineNum)
    {
        if (paymentInfo == "#" || cost == "#" || date == "#" || numNights == "#" || room == "#" // Makes sure importing from file doesn't have an obvious issue
            || name == "#" || phone == "#" || type == "#" || email == "#" || datePaid == "#")
        {
            addToRecord("Encountered an error creating a reservation from file. Check line " + lineNum);
        }
        else
        {
            Reservation newRes = new Reservation(paymentInfo, cost, date, numNights, room, name, phone, type, email, datePaid);
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
        StreamWriter sw = new StreamWriter(".\\Hotel\\Storage\\recordData.txt", true);
        sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss ") + s);
        sw.Close();
    }

    public static int searchReservation(String name,int index)
    {
        if(name == null)
        {
            return -1;
        }
        if(index == -1)
        {
            index = 0;
        }
        for (int i = index; i<resList.Count; i++)
        {
            
            if (resList[i].getName().ToUpper().Contains(name.ToUpper()))
            {
                index = i;
                return index;
            }
        }
        return -1;
    }

    public static void cancelReservation(Reservation r)
    {
        deleteFromFile(r);
        addToRecord("Cancelled Reservation: " + r.toString());
        resList.Remove(r);
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
        using(StreamReader sr = new StreamReader(".\\Hotel\\Storage\\Users.txt"))
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
        using (StreamReader sr = new StreamReader(".\\Hotel\\Storage\\Users.txt"))
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
