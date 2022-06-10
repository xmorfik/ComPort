using System.IO.Ports;

namespace DataAnalyse
{
    public partial class DataAnalyse : Form
    {
        private const int defaultSize = 24;
        private static int bufferSizeRead = defaultSize;
        private static int bufferSizeWrite = defaultSize;
        private static byte[] bufferRead = new byte[bufferSizeRead];
        private static byte[] bufferPrevRead = new byte[bufferSizeRead];
        private static byte[] bufferWrite = new byte[bufferSizeWrite];
        private static SerialPort _sp = new SerialPort();
        private static PortSettings.PortSettings settings = new PortSettings.PortSettings(ref _sp);
        private static Emulator.Filter filterForm = new Emulator.Filter(ref _sp);

        public DataAnalyse()
        {
            InitializeComponent();
            _sp.DataReceived += DataReceivedHandler;
            numericUpDown1.Minimum = 8;
            numericUpDown1.Maximum = 40;
            numericUpDown1.Value = defaultSize;
            
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            Array.Copy(bufferRead, bufferPrevRead, bufferSizeRead);
            Array.Clear(bufferRead);
            sp.Read(bufferRead, 0, bufferSizeRead);
            sp.DiscardInBuffer();
            WriteData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (settings.IsDisposed)
            {
                settings = new PortSettings.PortSettings(ref _sp);
            }
            settings.Show();

        }

        public void WriteData()
        {
            Action action = () => richTextBox1.Text = BitConverter.ToString(bufferRead);
            Invoke(action);
        }

        private void DataCheck()
        {
            string sCurent = BitConverter.ToString(bufferRead);
            string sPrev = BitConverter.ToString(bufferPrevRead);

            if (sCurent.Length != sPrev.Length)
            {
                return;
            }

            for (int i = 0; i < sPrev.Length; i++)
            {
                if (sPrev[i] == '-')
                {
                    continue;
                }
                if (sCurent[i] != sPrev[i])
                {
                    richTextBox1.Select(i, 2);
                    richTextBox1.SelectionColor = Color.Red;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataCheck();
            if (button.BackColor == Color.GreenYellow)
            {
                button.BackColor = Color.Violet;
            }
            else
            {
                button.BackColor = Color.GreenYellow;
            }

            filterForm.GetText(richTextBox1.Text);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bufferSizeRead = Convert.ToInt32(numericUpDown1.Value);
            bufferSizeWrite = Convert.ToInt32(numericUpDown1.Value);
            bufferRead = new byte[Convert.ToInt32(numericUpDown1.Value)];
            bufferPrevRead = new byte[Convert.ToInt32(numericUpDown1.Value)];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (filterForm.IsDisposed)
            {
                filterForm = new Emulator.Filter(ref _sp);
            }
            filterForm.Show();
        }
    }
}