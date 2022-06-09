using System.IO.Ports;

namespace Emulator
{
    public partial class EmulatorForm : Form
    {

        SerialPort _sp = new SerialPort();
        List <ListenData> _listenDatas = new List <ListenData>();

        public EmulatorForm()
        {
            InitializeComponent();
        }

        public EmulatorForm(ref SerialPort sp)
        {
            InitializeComponent();
            _sp = sp;
        }



        public void GetData(byte[] array, int leght)
        {
            richTextBox1.Text += BitConverter.ToString(array) + "\n";
        }

        public void GetText(string s)
        {
            if(CheckPak(s))
            {
                richTextBox1.Text += s + "\n";
            }
        }

        public void AddText()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListenData ld = new ListenData((int)numericUpDown1.Value, (int)numericUpDown2.Value,textBox1.Text);
            _listenDatas.Add(ld);
            textBox2.Text += ld.GetMe() + "\n";
        }

        bool CheckPak(string pak)
        {
            if (_listenDatas.Count == 0) 
            { 
            return true;
            }
            else
            {
                foreach (ListenData ld in _listenDatas)
                {
                    if(false == ld.Check(pak))
                    {
                        return false;
                    }
                    
                }
                return true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _listenDatas.Clear();
            numericUpDown1.Value = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown2.Value = 0;
        }
    }
}