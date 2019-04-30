﻿using System;

using System.IO;
using System.Collections;
using System.Collections.Generic;

public class DataController
{
    public static string user;
    public static bool isManager;
    public static int count;
    public static String PhoneNum, SearchName;
    public static Calendar calendar = new Calendar();
    public static List<Reservation> resList = new List<Reservation>();

    public DataController() {}

    public static void createReservation(string paymentInfo, double cost, string date,int numNights, int room, String name,  String phone, String type, String email)
    {
        Reservation newRes = new Reservation(paymentInfo, cost, date, numNights, room, name,phone, type, email);
        resList.Add(new Reservation(paymentInfo, cost, date,numNights, room, name,phone, type, email));
        addToRecord("Created Reservation: " + newRes.toString());
        //Date thisDate = calendar[calendar.Values.Count - 1];
        //int size = calendar.Values. ;
    }

    public static void addToRecord(string s)
    {
        StreamWriter sw = new StreamWriter("../recordData.txt", true);
        sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss ") + s);
        sw.Close();
    }

    public static Reservation searchReservation( String name)
    {
        for (int i=0; i<resList.Count; i++)
        {
            
            if (resList[i].getName().ToUpper() == name.ToUpper())
            {
                return resList[i];
            }
            

        }
        return null;
    }
    public static void cancelReservation(int index)
    {
        resList[index] = null;

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

    //public static void getReservations(SortedDictionary<string, Reservation> &a)
    //{
        //;
    //}
}
