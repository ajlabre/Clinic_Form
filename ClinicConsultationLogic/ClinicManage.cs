using System;
using ClinicConsultationLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicConsultationLogic
{
    internal class ClinicManage
    {

        static List<string> name = new List<string>();
        static List<string> address = new List<string>();
        static List<string> bdate = new List<string>();
        static List<string> gender = new List<string>();
        static List<string> email = new List<string>();
        static List<string> mobnum = new List<string>();
        static List<string> medhistory = new List<string>();

        static List<string> username = new List<string>();
        static List<string> pin = new List<string>();

        static string[] action = new[]
            {
                "Please type 'next' to proceed with your consultation.",
                "Please type 'search' to search your name.",
                "Please type 'login' to login admin.",
                "Please type 'register' to register a new admin.",
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

                    case "search":

                        FindUser();
                        Console.WriteLine();
                        DisplayActions();

                        break;

                    case "login":

                        LoginAdmin();
                        Console.WriteLine();
                        DisplayActions();

                        break;

                    case "register":

                        RegisterAdmin();
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

            Console.Write("Enter Full name: ");
            string EnterName = Console.ReadLine();
            Console.Write("Enter Address: ");
            string EnterAddress = Console.ReadLine();
            Console.Write("Enter Birthdate: ");
            string EnterBdate = Console.ReadLine();
            Console.Write("Enter Gender (F/M): ");
            string EnterGender = Console.ReadLine();
            Console.Write("Enter Email Address: ");
            string EnterEmail = Console.ReadLine();
            Console.Write("Enter mobile number: ");
            string EnterMobnum = Console.ReadLine();
            Console.Write("Enter medical history: ");
            string EnterMhistory = Console.ReadLine();

            name.Add(EnterName);
            address.Add(EnterAddress);
            bdate.Add(EnterBdate);
            gender.Add(EnterGender);
            email.Add(EnterEmail);
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

        public static void LoginAdmin() {

            Console.WriteLine("LOGIN CLIENT");
            Console.WriteLine();

            Console.Write("Enter Username: ");
            string Username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string Password = Console.ReadLine();
        }

        public static void RegisterAdmin(){

            string Username = string.Empty;
            string Pin = string.Empty;

            Console.WriteLine("REGISTER CLIENT");
            Console.WriteLine();

            for (int i = 0; i < username.Count; i++)
            {
                Console.WriteLine("Username: " + username[i]);
                Console.WriteLine("Password: " + pin[i]);
            }

            Console.Write("Enter Username: ");
            string EnterUsername = Console.ReadLine();

            Console.Write("Enter Pin: ");
            string EnterPin = Console.ReadLine();

            username.Add(EnterUsername);
            pin.Add(EnterPin);

            bool success = username.Contains(EnterUsername) && pin.Contains(EnterPin);

            if (success)
            {
                Console.WriteLine("Registered.");
            }
            else
            {
                Console.WriteLine("This admin exists.");
            }

        }


    }
}
