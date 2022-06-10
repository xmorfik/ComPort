namespace HashSum
{
    public partial class HashSum : Form
    {
        delegate byte[] HashSumDelegate(byte[] data);
        
        private string logic;

        public HashSum()
        {
            InitializeComponent();    
        }

        private static byte[] StringToByteArray(String hex)
        {
            hex = hex.Replace("-", "");
            hex = hex.Replace(" ", "");
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void SimpleSum(string s)
        {
            byte[] bytes = StringToByteArray(s);
            byte[] sum = new byte[4];
            byte FF = byte.MaxValue;
            foreach (byte b in bytes)
            {
                sum[0] += b;
                
            }
            textBox3.Text = BitConverter.ToString(sum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleSum(textBox1.Text);
        }
    }
}