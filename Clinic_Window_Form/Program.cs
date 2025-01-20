namespace Clinic_Window_Form
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ADMINCLIENTMENU());
        }
    }
}