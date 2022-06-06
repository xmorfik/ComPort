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

            //PortSettings.PortSettings ps = new PortSettings.PortSettings();
            //Application.Run(ps);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new DataAnalyse());
            
           

            //var settForm = new PortSettings.PortSettings();

            
        }
    }
}