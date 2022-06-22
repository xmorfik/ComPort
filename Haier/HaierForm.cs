namespace Haier
{
    public partial class HaierForm : Form
    {
        const int defSize = 16;
        Package resivedPackage;
        public HaierForm()
        {
            InitializeComponent();
            resivedPackage = new Package(defSize);
            sizeOfPackage.Value = defSize;
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
    }
}