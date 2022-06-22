namespace Emulator
{
    internal class ListenData
    {
        private int Start;
        private int Lenght;
        private string ListenBytes { get; set; }
        public ListenData(int start, int lenght, string listenData)
        {
            this.Start = start;
            this.Lenght = lenght;
            this.ListenBytes = listenData;
        }
        public bool Check(string data)
        {
            //string s = data.Replace("-", "");
            byte[] bytes = StringToByteArray(data);
            byte[] cutPak = bytes[Start..(Start + Lenght)];
            byte[] listenBytes = StringToByteArray(ListenBytes);
            return listenBytes.SequenceEqual(cutPak);
        }
        private static byte[] StringToByteArray(String hex)
        {
            hex = hex.Replace("-", "");
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        private void test()
        {
            ListenBytes = "33-44-55";
            MessageBox.Show(Check("11-22-33-44-55-66").ToString());
        }
        public string GetMe()
        {
            return ListenBytes + " from " + Start.ToString() + " to " + (Start + Lenght).ToString();
        }
    }
}
