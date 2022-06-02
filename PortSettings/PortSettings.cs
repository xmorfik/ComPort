using System.IO.Ports;

namespace PortSettings
{
    public partial class PortSettings : Form
    {
        static SerialPort _serialPort = new SerialPort();
        public PortSettings()
        {
            InitializeComponent();
            SetComboBoxes();
            SetSerialPort();
        }
        public void SetComboBoxes()
        {
            RefillPorts();
            try
            { 
            comboBox1.SelectedIndex = 0;
            }catch(Exception ex)
            {

            }

            comboBox2.Items.Add(110);
            comboBox2.Items.Add(300);
            comboBox2.Items.Add(600);
            comboBox2.Items.Add(1200);
            comboBox2.Items.Add(2400); 
            comboBox2.Items.Add(4800);
            comboBox2.Items.Add(9600);
            comboBox2.Items.Add(14400);
            comboBox2.Items.Add(19200);
            comboBox2.Items.Add(38400);
            comboBox2.Items.Add(56000);
            comboBox2.Items.Add(115200);
            comboBox2.Items.Add(128000);
            comboBox2.Items.Add(256000);
            comboBox2.SelectedIndex = 6;

            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                comboBox3.Items.Add(s);
            }
            comboBox3.SelectedIndex = 0;

            comboBox4.Items.Add(5);
            comboBox4.Items.Add(6);
            comboBox4.Items.Add(7);
            comboBox4.Items.Add(8);
            comboBox4.SelectedIndex = 3;

            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                 comboBox5.Items.Add(s);
            }
            comboBox5.SelectedIndex = 1;
        }
        public void RefillPorts()
        {
            comboBox1.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedIndex = 0;
            
        }
        public void GetSerialPort(ref SerialPort sp)
        {
            _serialPort = sp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!_serialPort.IsOpen)
            {
                try
                {
                    _serialPort.Open();
                }catch (Exception ex)
                {
                    MessageBox.Show("Port not found");
                    RefillPorts();
                }
            }
            
            if(_serialPort.IsOpen)
            {
                ProtectComboBoxes();
            }

            label6.Text = Convert.ToString(_serialPort.IsOpen); 
        }
        public void SetSerialPort()
        {
            try
            {
                _serialPort.PortName = (String)(comboBox1.SelectedItem);
            }
            catch
            {
            }
            _serialPort.BaudRate = (int)(comboBox2.SelectedItem);
            _serialPort.Parity   = (Parity)(comboBox3.SelectedIndex);
            _serialPort.DataBits = (int)(comboBox4.SelectedItem);
            _serialPort.StopBits = (StopBits)(comboBox5.SelectedIndex);
        }
        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetSerialPort();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            if(!_serialPort.IsOpen)
            {
                EnableComboBoxes();
            }

            label6.Text = Convert.ToString(_serialPort.IsOpen);
        }
        public void ProtectComboBoxes()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            button3.Enabled = false;
        }
        public void EnableComboBoxes()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            button3.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RefillPorts();
        }
    }
}