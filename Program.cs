namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///public static MatchForm? matchForm;
        ///public static TeamsForm? teamsForm;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //matchForm = new MatchForm();
            //teamsForm = new TeamsForm();
            Application.Run(new MatchForm());
            //matchForm.Dispose();
            //teamsForm.Dispose();
        }
    }
}