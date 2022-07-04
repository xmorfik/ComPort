using System.IO.Ports;

namespace Manager
{
    public partial class PackageManager : Form
    {
        List<byte> byteList = new List<byte>();
        const int defSize = 16;
        Package resivedPackage;
        PortSettings.PortSettings serialPortForm;
        Emulator.Filter filterForm;
        SerialPort serialPort;
       

        public PackageManager()
        {
            InitializeComponent();
            resivedPackage = new Package(defSize);
            sizeOfPackage.Value = defSize;
            serialPort = new SerialPort();
            serialPortForm = new PortSettings.PortSettings(ref serialPort);
            filterForm = new Emulator.Filter(ref serialPort);
            serialPort.DataReceived += DataReceivedHandler;
            PackageConverter();
        }

        async void PackageConverter()
        {
            await Task.Run(() => {
                while(true)
                {
                    if (byteList.Count >= resivedPackage.GetSize())
                    {
                        SendToFilter(byteList.ToArray());
                        resivedPackage.SetDataBytes(byteList.ToArray());
                        DecodeData();
                        byteList.Clear();
                    }
                }
            });
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var port = (SerialPort)sender;
            var count = port.BytesToRead;
            for (int i = 0; i < count; i++)
            {
                byteList.Add((byte)port.ReadByte());
            }
        }


        private void SetLenght_Click(object sender, EventArgs e)
        {
            resivedPackage.SetPackageLenght((int)sizeOfPackage.Value);
            RefreshSettingsTextBox();
        }
        private void Deserialize_Click(object sender, EventArgs e)
        {
            resivedPackage.Deserialize(nameOfFile.Text);
            RefreshSettingsTextBox();
        }
        private void Serialize_Click(object sender, EventArgs e)
        {
            resivedPackage.Serialize(nameOfFile.Text);
        }
        private void ApplyToSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if(!isNumberCheck.Checked)
                {
                    var valMean = new ValueMeaning(Package.ConvertStringToByteArray(hexNumber.Text)[0], meaningStr.Text);
                    resivedPackage.ByteSettings[(int)indexOfByte.Value].MeaningList.Add(valMean);
                }
                resivedPackage.ByteSettings[(int)indexOfByte.Value].IsNumber = isNumberCheck.Checked;
            }
            catch
            {
                MessageBox.Show("Filed");
            }
            hexNumber.Text  = "";
            meaningStr.Text = "";
            isNumberCheck.Checked = false;
            RefreshSettingsTextBox();
        }
        private void RefreshTextBox_Click(object sender, EventArgs e)
        {
            RefreshSettingsTextBox();
        }
        void RefreshSettingsTextBox()
        {
            textBox2.Text = resivedPackage.GetCurrentSettings();
        }
        private void ShowFormPort(object sender, EventArgs e)
        {
            if(serialPortForm.IsDisposed)
            {
                serialPortForm = new PortSettings.PortSettings(ref serialPort);
                serialPortForm.Show();
            }
            else
            {
                serialPortForm.Show();
            }
        }
        private void ShowFilterForm(object sender, EventArgs e)
        {
            if (serialPortForm.IsDisposed)
            {
                filterForm = new Emulator.Filter(ref serialPort);
                filterForm.Show();
            }
            else
            {
                filterForm.Show();
            }
        }
        void SendToFilter(byte[] array)
        {
            Action action = () => filterForm.GetData(array, resivedPackage.GetSize());
            Invoke(action);
        }
        private void Decode_Click(object sender, EventArgs e)
        {
            textBox1.Text = resivedPackage.GetDecodePackage();
        }
        private void DecodeData()
        {
            Action action = () => textBox1.Text = resivedPackage.GetDecodePackage();
            Invoke(action);
        }
    }
}