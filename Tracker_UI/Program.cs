namespace Tracker_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //run the program
            ApplicationConfiguration.Initialize();
            Application.Run(new TrackerUI.TournamentDashboardForm());
        }
    }
}