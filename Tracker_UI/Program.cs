namespace TrackerUI
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

            //initialize the database connection
            TrackerLibrary.GlobalConfig.InitializeConnections(TrackerLibrary.DatabaseType.Sql);
            Application.Run(new CreateTournament());

            //Application.Run(new TournamentDashboardForm());
        }
    }
}