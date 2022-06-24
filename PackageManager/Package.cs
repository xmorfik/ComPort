using System.Text.Json;

namespace Manager
{
    [Serializable]
    internal class Package
    {
        private byte[] DataBytes;
        private int Size;
        public List<ByteSetting> ByteSettings { get; set; }
        public Package(int lenght)
        {
            DataBytes = new byte[lenght];
            ByteSettings = new List<ByteSetting>();
            SetPackageLenght(lenght);
            Size = lenght;
        }
        public void SetDataBytes(byte[] array)
        {
            if (array.Length != Size)
            {
                DataBytes = new byte[array.Length];
                SetPackageLenght(array.Length);
            }
            Array.Copy(array, DataBytes, array.Length);
        }
        public void SetPackageLenght(int lenght)
        {
            if (ByteSettings.Count < lenght)
            {
                for (int i = ByteSettings.Count; i < lenght; i++)
                {
                    ByteSettings.Add(new ByteSetting(i, true));
                }
                Size = lenght;
                return;
            }
            else if (ByteSettings.Count > lenght)
            {
                ByteSettings.RemoveRange(lenght, ByteSettings.Count - lenght);
                Size = lenght;
                return;
            }
            else
            {
                return;
            }
        }
        public void Serialize(string nameOfFile)
        {
            Stream stream;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            try
            {
                stream = new FileStream(nameOfFile, FileMode.Create, FileAccess.Write, FileShare.None);
                JsonSerializer.Serialize(stream, ByteSettings, options);
            }
            catch
            {
                MessageBox.Show("Fali serialize");
                return;
            }
            stream.Close();
        }
        public void Deserialize(string nameOfFile)
        {
            Stream stream;
            ByteSetting[]? obj;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            try
            {
                stream = new FileStream(nameOfFile, FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch
            {
                MessageBox.Show("Fail, wrong name of file");
                return;
            }

            try
            {
                obj = JsonSerializer.Deserialize<ByteSetting[]>(stream, options);
            }
            catch
            {
                MessageBox.Show("Fail, undeserializeble content");
                stream.Close();
                return;
            }

            if (obj == null)
            {
                MessageBox.Show("obj == null");
                stream.Close();
                return;
            }

            ByteSettings.Clear();

            foreach (ByteSetting b in obj)
            {
                ByteSettings.Add(b);
            }
            Size = obj.Length;

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
        public string GetCurrentSettings()
        {
            string settings = "";

            for (int i = 0; i < ByteSettings.Count; i++)
            {
                settings += $"{i}. {ByteSettings[i].IsNumber}  \r\n";
                for (int j = 0; j < ByteSettings[i].MeaningList.Count; j++)
                {
                    settings += $"      {ByteSettings[i].MeaningList[j].Value.ToString("X")} --- {ByteSettings[i].MeaningList[j].Meaning} \r\n";
                }
            }

            return settings;
        }
        public string GetDecodePackage()
        {
            string meaning = "";

            for (int i = 0; i < ByteSettings.Count; i++)
            {
                if (ByteSettings[i].IsNumber)
                {
                    meaning += $"{i}. {DataBytes[i].ToString("X")} \r\n";
                    continue;
                }
                else
                {
                    meaning += $"{i}. {DataBytes[i].ToString("X")} \r\n";
                    for (int j = 0; j < ByteSettings[i].MeaningList.Count; j++)
                    {
                        if (DataBytes[i] == ByteSettings[i].MeaningList[j].Value)
                        {
                            meaning += $"{i}. --- {ByteSettings[i].MeaningList[j].Meaning} \r\n";
                            break;
                        }
                    }
                }
            }

            return meaning;
        }
        public int GetSize()
        {
            return Size;
        }
    }
}
