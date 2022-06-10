using PortSettings;

namespace DataAnalyse
{
    internal static class ProgramData
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DataAnalyse());

        }
    }
}