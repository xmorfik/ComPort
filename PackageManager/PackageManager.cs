using System.IO.Ports;

namespace Manager
{
    public partial class PackageManager : Form
    {
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
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            sp.Read(resivedPackage.DataBytes, 0, resivedPackage.GetSize());
            sp.DiscardInBuffer();
        }
        private void SetLenght_Click(object sender, EventArgs e)
        {
            resivedPackage.SetPackageLenght((int)sizeOfPackage.Value);
            RefreshTextBox();
        }
        private void Deserialize_Click(object sender, EventArgs e)
        {
            resivedPackage.Deserialize(nameOfFile.Text);
            RefreshTextBox();
        }
        private void Serialize_Click(object sender, EventArgs e)
        {
            resivedPackage.Serialize(nameOfFile.Text);
        }
        private void applyToSettings_Click(object sender, EventArgs e)
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
            RefreshTextBox();
        }
        private void refreshTextBox_Click(object sender, EventArgs e)
        {
            RefreshTextBox();
        }
        void RefreshTextBox()
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
    }
}