namespace Haier
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
            Application.Run(new PackageManager());
            //Package package = new Package(18);
            //package.RefreshBytesArray(Package.ConvertStringToByteArray("E7 14 AA 55 0E 00 80 09 00 57 57 56 57 56 02 00 00 4A"));
            //package.ByteSettings[1].MeaningList.Add(new ValueMeaning(20, "HEAT OFF"));
            //package.ByteSettings[1].MeaningList.Add(new ValueMeaning(13, "HEAT ON"));
            //package.ByteSettings[1].MeaningList.Add(new ValueMeaning(14, "NONE"));
            //package.ByteSettings[1].IsNumber = false;
            //string str = package.ByteSettings[1].GetMeaning(package.DataBytes[1]);
            //package.ByteSettings[1].IsNumber = true;
            //string str2 = package.ByteSettings[1].GetMeaning(package.DataBytes[1]);
            ////ValueMeaning valueMeaning = new ValueMeaning(1,"1..2");
            ////ValueMeaning valueMeaning2 = new ValueMeaning(2, "1./.2");
            ////ValueMeaning valueMeaning3 = new ValueMeaning(3, "1.//.2");
            ////Byte _byte = new Byte(4, 12);
            ////Byte _byte2 = new Byte(5, 13);
            ////Byte _byte3 = new Byte(6, 14);

            ////_byte.MeaningList.Add(valueMeaning);
            ////_byte2.MeaningList.Add(valueMeaning2);
            ////_byte3.MeaningList.Add(valueMeaning3);

            ////package.Bytes.Add(_byte);
            ////package.Bytes.Add(_byte2);
            ////package.Bytes.Add(_byte3);

            //package.Serialize();
            //package.Deserialize("Package.json");
        }
    }
}