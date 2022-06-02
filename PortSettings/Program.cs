using System.IO.Ports;

namespace PortSettings
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            PortSettings form = new PortSettings();
            SerialPort sp = new SerialPort();
            form.GetSerialPort(ref sp);
            Application.Run(form);
        }
    }
}