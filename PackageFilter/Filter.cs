using System.IO.Ports;

namespace Emulator
{
    public partial class Filter : Form
    {
        private SerialPort _sp = new SerialPort();
        private List<ListenData> _listenDatas = new List<ListenData>();

        public Filter()
        {
            InitializeComponent();
        }

        public Filter(ref SerialPort sp)
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
            if (CheckPak(s))
            {
                richTextBox1.Text += s + "\n";
            }
        }

        public void AddText()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListenData ld = new ListenData((int)numericUpDown1.Value, (int)numericUpDown2.Value, textBox1.Text);
            _listenDatas.Add(ld);
            richTextBox2.Text += ld.GetMe() + "\n";
        }

        private bool CheckPak(string pak)
        {
            if (_listenDatas.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (ListenData ld in _listenDatas)
                {
                    if (false == ld.Check(pak))
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
            richTextBox2.Text = "";
            numericUpDown2.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}