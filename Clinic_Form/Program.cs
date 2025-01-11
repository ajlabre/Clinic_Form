using System.Collections.Concurrent;
using System;

namespace clinic_form
{
    internal class Program
    {

        static List<string> name = new List<string>();
        static List<string> address = new List<string>();
        static List<string> bdate = new List<string>();
        static List<string> gender = new List<string>();
        static List<string> email = new List<string>();
        static List<string> date = new List<string>();
        static List<string> mobnum = new List<string>();
        static List<string> medhistory = new List<string>();

        static string[] action = new[]
            {
                "Please type 'next' to proceed with your consultation.",
                "Please type 'cancel' to cancel your consultation.",
                "Please type 'search' to search your name."
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

                    case "search":

                        FindUser();
                        Console.WriteLine();
                        DisplayActions();

                        break;


                    case "cancel":

                        Console.WriteLine("Happy to be of service!");
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
            Console.Write("Enter date today: ");
            string EnterDate = Console.ReadLine();
            Console.Write("Enter mobile number: ");
            string EnterMobnum = Console.ReadLine();
            Console.Write("Enter medical history: ");
            string EnterMhistory = Console.ReadLine();

            name.Add(EnterName);
            address.Add(EnterAddress);
            bdate.Add(EnterBdate);
            gender.Add(EnterGender);
            email.Add(EnterEmail);
            date.Add(EnterDate);
            mobnum.Add(EnterMobnum);
            medhistory.Add(EnterMhistory);

            Console.WriteLine("Successfully added client: " + EnterName);
        }
        public static bool FindUser()
        {
            Console.Write("Search name: ");
            string toSearch = Console.ReadLine();

            if (name.Contains(toSearch))
            {
                Console.WriteLine(name + " :This client exists.");
                return true;
            }
            else
            {
                Console.WriteLine(toSearch + " does not exist.");
                return false;
            }
        }
    }
}