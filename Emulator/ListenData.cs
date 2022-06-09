using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulator
{
    internal class ListenData
    {
        int start;
        int lenght;
        string listenData { get; set; }

        public ListenData(int start, int lenght, string listenData )
        {
            this.start = start; 
            this.lenght = lenght;
            this.listenData = listenData;
        }

        public ListenData()
        {
            
        }

        public bool Check(string data)
        {
            //string s = data.Replace("-", "");
            byte[] bytes = StringToByteArray(data);
            byte[] cutPak = bytes[start..(start + lenght)];
            byte[] listenBytes = StringToByteArray(listenData);
            return listenBytes.SequenceEqual(cutPak);
        }

        static byte[] StringToByteArray(String hex)
        {
            hex = hex.Replace("-", "");
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        void test()
        {
            listenData = "33-44-55";
            MessageBox.Show(Check("11-22-33-44-55-66").ToString());
        }

        public string GetMe()
        {
            return listenData + " from " + start.ToString() + " to " + (start+lenght).ToString() ;
        }
    }
}
