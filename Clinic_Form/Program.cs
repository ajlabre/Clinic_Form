﻿using System.Collections.Concurrent;
using System;
using ClinicConsultationLogic;
using System.Net.NetworkInformation;

namespace clinic_form
{
    internal class Program
    {

        //static List<string> name = new List<string>();
        //static List<string> address = new List<string>();
        //static List<string> bdate = new List<string>();
        //static List<string> gender = new List<string>();
        //static List<string> email = new List<string>();
        //static List<string> mobnum = new List<string>();
        //static List<string> medhistory = new List<string>();

        //static List<string> username = new List<string>();
        //static List<string> pin = new List<string>();

        static string[] action = new[]
            {
                "Please type 'next' to proceed with your consultation.",
                "Please type 'view' to view your name.",
                "Please type 'add' to register a new admin.",
                "Please type 'exit' to exit the consultation form."
            };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Clinic Consultation Form!");
            Console.WriteLine();

            DisplayActions();
            string useract = EnterAction();

            while (useract != "exit")
            {

                switch (useract)
                {
                    case "next":

                        AddUser();
                        Console.WriteLine();
                        DisplayActions();

                        break;

                    case "view":

                        ViewClient();
                        Console.WriteLine();
                        DisplayActions();

                        break;

                    case "add":

                        AddAdmin();
                        Console.WriteLine();
                        DisplayActions();

                        break;
                    default:

                        Console.WriteLine("Incorrect input.");

                        break;
                }

                useract = EnterAction();

            }
            Console.WriteLine("Happy to be of service!");
            Environment.Exit(0);
        }
        static public void DisplayActions()
        {
            foreach (var act in action)
            {
                Console.WriteLine(act);
            }
        }
        public static string EnterAction()

        {

            Console.Write("Enter Action: ");
            return Console.ReadLine()?.ToLower();

        }
        public static void AddUser()
        {

            Console.WriteLine("ADD CLIENT");
            Console.WriteLine();

            Console.Write("Enter name: ");
            string EnterName = Console.ReadLine();
            Console.Write("Enter address: ");
            string EnterAddress = Console.ReadLine();
            Console.Write("Enter birthdate: ");
            string EnterBdate = Console.ReadLine();
            Console.Write("Enter gender (F/M): ");
            string EnterGender = Console.ReadLine();
            Console.Write("Enter email address: ");
            string EnterEmail = Console.ReadLine();
            Console.Write("Enter mobile number: ");
            string EnterMobnum = Console.ReadLine();
            Console.Write("Enter medical history: ");
            string EnterMhistory = Console.ReadLine();

            ClinicConsultationLogic.AddUser(EnterName, EnterAddress, EnterBdate,
            EnterGender, EnterEmail, EnterMobnum, EnterMhistory);

            Console.WriteLine("Successfully added client: " + EnterName);
        }
        public static bool ViewClient(string name)
        {
            Console.Write("Search name: "); 
            string toSearch = Console.ReadLine();

            Console.WriteLine("This client exists: " + toSearch);
            return ClinicConsultationLogic.ViewClient(toSearch) ;
        }
        public static void AddAdmin()
        {
            string username = string.Empty;
            string pin = string.Empty;

            Console.WriteLine("ADD CLIENT");
            Console.WriteLine();

            Console.Write("Enter Username: ");
            string EnterUsername = Console.ReadLine();

            Console.Write("Enter Pin: ");
            string EnterPin = Console.ReadLine();

            ClinicConsultationLogic.AddAdmin(EnterUsername,EnterPin);

            Console.WriteLine("Successfully added admin: " + EnterUsername);

        }


    }
}