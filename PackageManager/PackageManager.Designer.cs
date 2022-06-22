﻿namespace Haier
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
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshTextBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.indexOfByte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // indexOfByte
            // 
            this.indexOfByte.Location = new System.Drawing.Point(79, 10);
            this.indexOfByte.Name = "indexOfByte";
            this.indexOfByte.Size = new System.Drawing.Size(120, 23);
            this.indexOfByte.TabIndex = 1;
            // 
            // meaningStr
            // 
            this.meaningStr.Location = new System.Drawing.Point(79, 68);
            this.meaningStr.Name = "meaningStr";
            this.meaningStr.Size = new System.Drawing.Size(120, 23);
            this.meaningStr.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 120);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 317);
            this.textBox2.TabIndex = 3;
            // 
            // hexNumber
            // 
            this.hexNumber.Location = new System.Drawing.Point(79, 39);
            this.hexNumber.Name = "hexNumber";
            this.hexNumber.Size = new System.Drawing.Size(120, 23);
            this.hexNumber.TabIndex = 4;
            // 
            // nameOfFile
            // 
            this.nameOfFile.Location = new System.Drawing.Point(79, 344);
            this.nameOfFile.Name = "nameOfFile";
            this.nameOfFile.Size = new System.Drawing.Size(120, 23);
            this.nameOfFile.TabIndex = 5;
            this.nameOfFile.Text = "package.json";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 373);
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
            this.isNumberCheck.Location = new System.Drawing.Point(229, 10);
            this.isNumberCheck.Name = "isNumberCheck";
            this.isNumberCheck.Size = new System.Drawing.Size(78, 19);
            this.isNumberCheck.TabIndex = 7;
            this.isNumberCheck.Text = "IsNumber";
            this.isNumberCheck.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 402);
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
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Значение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Байт";
            // 
            // applyToSettings
            // 
            this.applyToSettings.Location = new System.Drawing.Point(229, 68);
            this.applyToSettings.Name = "applyToSettings";
            this.applyToSettings.Size = new System.Drawing.Size(120, 23);
            this.applyToSettings.TabIndex = 12;
            this.applyToSettings.Text = "Применить";
            this.applyToSettings.UseVisualStyleBackColor = true;
            this.applyToSettings.Click += new System.EventHandler(this.applyToSettings_Click);
            // 
            // sizeOfPackage
            // 
            this.sizeOfPackage.Location = new System.Drawing.Point(79, 120);
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
            this.sizeOfPackage.Size = new System.Drawing.Size(120, 23);
            this.sizeOfPackage.TabIndex = 13;
            this.sizeOfPackage.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Размер";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SetLenght_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Сохранить конфигурацию";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Текущие настройки";
            // 
            // refreshTextBox
            // 
            this.refreshTextBox.Location = new System.Drawing.Point(355, 414);
            this.refreshTextBox.Name = "refreshTextBox";
            this.refreshTextBox.Size = new System.Drawing.Size(75, 23);
            this.refreshTextBox.TabIndex = 18;
            this.refreshTextBox.Text = "Обновить";
            this.refreshTextBox.UseVisualStyleBackColor = true;
            this.refreshTextBox.Click += new System.EventHandler(this.refreshTextBox_Click);
            // 
            // HaierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.refreshTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sizeOfPackage);
            this.Controls.Add(this.applyToSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.isNumberCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameOfFile);
            this.Controls.Add(this.hexNumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.meaningStr);
            this.Controls.Add(this.indexOfByte);
            this.Name = "HaierForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.indexOfByte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfPackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label4;
        private Button button4;
        private Label label5;
        private Label label6;
        private Button refreshTextBox;
    }
}