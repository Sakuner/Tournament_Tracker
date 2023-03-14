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
            TrackerLibrary.GlobalConfig.InitializeConnections(true,true);
            Application.Run(new CreatePrizeForm());

            //Application.Run(new TournamentDashboardForm());
        }
    }
}