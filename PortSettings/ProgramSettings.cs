namespace PortSettings
{
    public static class ProgramSettings
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //SerialPort sp = new SerialPort();

            //form.GetSerialPort(ref sp);
            Application.Run(new PortSettings());
        }
    }
}