namespace Manager
{
    partial class PackageManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.indexOfByte = new System.Windows.Forms.NumericUpDown();
            this.meaningStr = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hexNumber = new System.Windows.Forms.TextBox();
            this.nameOfFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.isNumberCheck = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.applyToSettings = new System.Windows.Forms.Button();
            this.sizeOfPackage = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.refreshTextBox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.indexOfByte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfPackage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // indexOfByte
            // 
            this.indexOfByte.Location = new System.Drawing.Point(109, 22);
            this.indexOfByte.Name = "indexOfByte";
            this.indexOfByte.Size = new System.Drawing.Size(120, 23);
            this.indexOfByte.TabIndex = 1;
            // 
            // meaningStr
            // 
            this.meaningStr.Location = new System.Drawing.Point(109, 80);
            this.meaningStr.Name = "meaningStr";
            this.meaningStr.Size = new System.Drawing.Size(120, 23);
            this.meaningStr.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(165, 616);
            this.textBox2.TabIndex = 3;
            // 
            // hexNumber
            // 
            this.hexNumber.Location = new System.Drawing.Point(109, 51);
            this.hexNumber.Name = "hexNumber";
            this.hexNumber.Size = new System.Drawing.Size(120, 23);
            this.hexNumber.TabIndex = 4;
            // 
            // nameOfFile
            // 
            this.nameOfFile.Location = new System.Drawing.Point(6, 22);
            this.nameOfFile.Name = "nameOfFile";
            this.nameOfFile.Size = new System.Drawing.Size(120, 23);
            this.nameOfFile.TabIndex = 5;
            this.nameOfFile.Text = "package.json";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // isNumberCheck
            // 
            this.isNumberCheck.AutoSize = true;
            this.isNumberCheck.Location = new System.Drawing.Point(109, 109);
            this.isNumberCheck.Name = "isNumberCheck";
            this.isNumberCheck.Size = new System.Drawing.Size(102, 19);
            this.isNumberCheck.TabIndex = 7;
            this.isNumberCheck.Text = "Только число";
            this.isNumberCheck.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Байт";
            // 
            // applyToSettings
            // 
            this.applyToSettings.Location = new System.Drawing.Point(109, 134);
            this.applyToSettings.Name = "applyToSettings";
            this.applyToSettings.Size = new System.Drawing.Size(120, 23);
            this.applyToSettings.TabIndex = 12;
            this.applyToSettings.Text = "Применить";
            this.applyToSettings.UseVisualStyleBackColor = true;
            this.applyToSettings.Click += new System.EventHandler(this.ApplyToSettings_Click);
            // 
            // sizeOfPackage
            // 
            this.sizeOfPackage.Location = new System.Drawing.Point(6, 22);
            this.sizeOfPackage.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.sizeOfPackage.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sizeOfPackage.Name = "sizeOfPackage";
            this.sizeOfPackage.Size = new System.Drawing.Size(80, 23);
            this.sizeOfPackage.TabIndex = 13;
            this.sizeOfPackage.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 52);
            this.button4.TabIndex = 15;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SetLenght_Click);
            // 
            // refreshTextBox
            // 
            this.refreshTextBox.Location = new System.Drawing.Point(177, 267);
            this.refreshTextBox.Name = "refreshTextBox";
            this.refreshTextBox.Size = new System.Drawing.Size(86, 23);
            this.refreshTextBox.TabIndex = 18;
            this.refreshTextBox.Text = "Обновить";
            this.refreshTextBox.UseVisualStyleBackColor = true;
            this.refreshTextBox.Click += new System.EventHandler(this.RefreshTextBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.applyToSettings);
            this.groupBox1.Controls.Add(this.indexOfByte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hexNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.meaningStr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.isNumberCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 181);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameOfFile);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 114);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сохранить";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sizeOfPackage);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(155, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 114);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Размер пакета";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.refreshTextBox);
            this.groupBox4.Location = new System.Drawing.Point(267, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 649);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Текущие настройки";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(12, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 141);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Комуникация";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Фильтр";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ShowFilterForm);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "Открыть порт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowFormPort);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Location = new System.Drawing.Point(543, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(308, 649);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Расшифровка";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(177, 296);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Фильтровать";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 23);
            this.textBox3.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(177, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Сдвиг";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.MovePac_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(177, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Расшифровка";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Decode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(165, 622);
            this.textBox1.TabIndex = 4;
            // 
            // PackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 673);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PackageManager";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.indexOfByte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfPackage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown indexOfByte;
        private TextBox meaningStr;
        private TextBox textBox2;
        private TextBox hexNumber;
        private TextBox nameOfFile;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox isNumberCheck;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button applyToSettings;
        private NumericUpDown sizeOfPackage;
        private Button button4;
        private Button refreshTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button button3;
        private GroupBox groupBox6;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox3;
        private CheckBox checkBox1;
    }
}