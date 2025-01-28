namespace ClinicConsultationLogic
{
    public static class ClinicManage
    {
        //LIST - NEXT METHOD - ADD USER
        //LIST - SEARCH METHOD - FIND USER
        //LIST - LOGIN METHOD - LOGIN ADMIN
        //LIST - REGISTER METHOD - REGISTER ADMIN

        public static List<string> name = new List<string>();
        public static List<string> address = new List<string>();
        public static List<string> bdate = new List<string>();
        public static List<string> gender = new List<string>();
        public static List<string> email = new List<string>();
        public static List<string> mobnum = new List<string>();
        public static List<string> medhistory = new List<string>();

        //ADMIN
        public static List<string> username = new List<string>();
        public static List<string> pin = new List<string>();

        public static bool ViewClient(string toSearch)
        {
            bool isExisting = name.Contains(toSearch);

            if (isExisting)
            {
                Console.WriteLine("Client scheduled.");
            }
            else
            {
                Console.WriteLine(toSearch + " Client not found.");
            }

            return isExisting;
        }

        public static bool ViewAdmin(string toSearch)
        {
            bool isExisting = username.Contains(toSearch);

            if (isExisting)
            {
                Console.WriteLine("Admin found.");
            }
            else
            {
                Console.WriteLine(toSearch + " Admin not found.");
            }

            return isExisting;
        }

        public static void AddUser(string EnterName, string EnterAddress, string EnterBdate,
            string EnterGender, string EnterEmail, string EnterMobnum, string EnterMhistory)
        {
            name.Add(EnterName);
            address.Add(EnterAddress);
            bdate.Add(EnterBdate);
            gender.Add(EnterGender);
            email.Add(EnterEmail);
            mobnum.Add(EnterMobnum);
            medhistory.Add(EnterMhistory);
        }

        public static void AddAdmin(string EnterUsername, string EnterPin)
        {
            username.Add(EnterUsername);
            pin.Add(EnterPin);
        }
    }
}
