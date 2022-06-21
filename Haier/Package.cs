using System;
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Haier
{
    [Serializable]
    internal class Package
    {
        public byte[] DataBytes;
        private int Size;
        public List <ByteSetting> ByteSettings { get; set; }
        public Package(int lenght)
        {
            DataBytes = new byte[lenght];
            ByteSettings = new List<ByteSetting>();
            Size = lenght;
            SetPackageLenght(lenght);
        }
        void SetPackageLenght(int lenght)
        {
            for(int i = 0; i< lenght; i++)
            {
                ByteSettings.Add(new ByteSetting(i,true));
            }
        }
        public void RefreshBytesArray(byte[] bytesArray)
        {
            if(bytesArray.Length != Size)
            {
                return;
            }
            DataBytes = bytesArray;
        }
        public void Serialize()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var stream = new FileStream("Package.json", FileMode.Create, FileAccess.Write, FileShare.None);
            JsonSerializer.Serialize(stream,ByteSettings,options);
            var str = JsonSerializer.Serialize(ByteSettings);
            stream.Close();
        }
        public static byte[] ConvertStringToByteArray(String hex)
        {
            hex = hex.Replace("-", "");
            hex = hex.Replace(" ", "");
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
