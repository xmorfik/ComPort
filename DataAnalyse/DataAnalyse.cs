using System.IO.Ports;
using PortSettings;

namespace DataAnalyse
{
    
    public partial class DataAnalyse : Form
    {
        const int defaultSize = 24;
        static int bufferSizeRead = defaultSize;
        static int bufferSizeWrite = defaultSize;

        static byte[] bufferRead = new byte[bufferSizeRead];
        static byte[] bufferPrevRead = new byte[bufferSizeRead];


        static byte[] bufferWrite = new byte[bufferSizeWrite];
        static SerialPort _sp = new SerialPort();
        static PortSettings.PortSettings settings = new PortSettings.PortSettings(ref _sp);

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
            if(settings.IsDisposed)
            {
               settings = new PortSettings.PortSettings(ref _sp);
            }
            settings.Show();
            
        }

        public void WriteData()
        {
            Action action = () => richTextBox1.Text = BitConverter.ToString(bufferRead);
            Invoke(action);
            //Action action = () => richTextBox1.Text = BitConverter.ToString(bufferRead);
            //Invoke(action);
            //Array.Clear(bufferRead, 0, bufferSizeRead);
        }

        void DataCheck()
        {
           
            //List <int> indexes = new List<int>();
            string sCurent = BitConverter.ToString(bufferRead);
            string sPrev = BitConverter.ToString(bufferPrevRead);

            if(sCurent.Length != sPrev.Length)
            {
                return;
            }

            for(int i=0; i< sPrev.Length; i++) 
            { 
                if(sPrev[i] == '-')
                {
                    continue;
                }
                if(sCurent[i]!=sPrev[i])
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
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bufferSizeRead = Convert.ToInt32(numericUpDown1.Value);
            bufferSizeWrite = Convert.ToInt32(numericUpDown1.Value);
            bufferRead = new byte[Convert.ToInt32(numericUpDown1.Value)];
            bufferPrevRead = new byte[Convert.ToInt32(numericUpDown1.Value)];
        }
    }
}