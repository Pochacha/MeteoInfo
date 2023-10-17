namespace MeteoInfo
{
    partial class Form1
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
            label1 = new Label();
            textBoxTemp = new TextBox();
            textBoxNote = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxWeather = new ComboBox();
            enterData = new Button();
            labelPath = new Label();
            printInfo = new Button();
            saveInDB = new Button();
            enteredInfo = new RichTextBox();
            label6 = new Label();
            saveInFile = new Button();
            label5 = new Label();
            successMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(163, 31);
            label1.TabIndex = 0;
            label1.Text = "Ввод данных";
            // 
            // textBoxTemp
            // 
            textBoxTemp.Location = new Point(30, 174);
            textBoxTemp.MaxLength = 3;
            textBoxTemp.Name = "textBoxTemp";
            textBoxTemp.ShortcutsEnabled = false;
            textBoxTemp.Size = new Size(100, 23);
            textBoxTemp.TabIndex = 1;
            textBoxTemp.KeyPress += textBoxTemp_KeyPress;
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(12, 336);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(257, 115);
            textBoxNote.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 143);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 4;
            label2.Text = "Температура в C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 217);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 5;
            label3.Text = "Погодные условия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 297);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 6;
            label4.Text = "Заметка";
            // 
            // comboBoxWeather
            // 
            comboBoxWeather.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWeather.FormattingEnabled = true;
            comboBoxWeather.Items.AddRange(new object[] { "Дождь", "Снег", "Град", "Ясно", "Облачно", "Туман" });
            comboBoxWeather.Location = new Point(30, 248);
            comboBoxWeather.Name = "comboBoxWeather";
            comboBoxWeather.Size = new Size(121, 23);
            comboBoxWeather.TabIndex = 7;
            // 
            // enterData
            // 
            enterData.Location = new Point(8, 85);
            enterData.Name = "enterData";
            enterData.Size = new Size(127, 38);
            enterData.TabIndex = 8;
            enterData.Text = "Ввести данные";
            enterData.UseVisualStyleBackColor = true;
            enterData.Click += enterData_Click;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPath.Location = new Point(13, 529);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(0, 21);
            labelPath.TabIndex = 9;
            // 
            // printInfo
            // 
            printInfo.Enabled = false;
            printInfo.Location = new Point(141, 85);
            printInfo.Name = "printInfo";
            printInfo.Size = new Size(106, 38);
            printInfo.TabIndex = 10;
            printInfo.Text = "Вывести отчет";
            printInfo.UseVisualStyleBackColor = true;
            printInfo.Click += printInfo_Click;
            // 
            // saveInDB
            // 
            saveInDB.Enabled = false;
            saveInDB.Location = new Point(381, 85);
            saveInDB.Name = "saveInDB";
            saveInDB.Size = new Size(106, 38);
            saveInDB.TabIndex = 11;
            saveInDB.Text = "Сохранить в БД";
            saveInDB.UseVisualStyleBackColor = true;
            saveInDB.Click += saveInDB_Click;
            // 
            // enteredInfo
            // 
            enteredInfo.Location = new Point(521, 68);
            enteredInfo.Name = "enteredInfo";
            enteredInfo.ReadOnly = true;
            enteredInfo.Size = new Size(267, 364);
            enteredInfo.TabIndex = 12;
            enteredInfo.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(624, 32);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 13;
            label6.Text = "Отчет";
            // 
            // saveInFile
            // 
            saveInFile.Enabled = false;
            saveInFile.Location = new Point(253, 85);
            saveInFile.Name = "saveInFile";
            saveInFile.Size = new Size(122, 38);
            saveInFile.TabIndex = 14;
            saveInFile.Text = "Сохранить в файл";
            saveInFile.UseVisualStyleBackColor = true;
            saveInFile.Click += SaveInFile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 489);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 15;
            label5.Text = "Путь к файлу:";
            label5.Visible = false;
            // 
            // successMessage
            // 
            successMessage.AutoSize = true;
            successMessage.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            successMessage.Location = new Point(8, 568);
            successMessage.Name = "successMessage";
            successMessage.Size = new Size(187, 21);
            successMessage.TabIndex = 16;
            successMessage.Text = "Операция выполнена!";
            successMessage.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(successMessage);
            Controls.Add(label5);
            Controls.Add(saveInFile);
            Controls.Add(label6);
            Controls.Add(enteredInfo);
            Controls.Add(saveInDB);
            Controls.Add(printInfo);
            Controls.Add(labelPath);
            Controls.Add(enterData);
            Controls.Add(comboBoxWeather);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNote);
            Controls.Add(textBoxTemp);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Приложение для метеоролога";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTemp;
        private TextBox textBoxNote;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxWeather;
        private Button enterData;
        private Label labelPath;
        private Button printInfo;
        private Button saveInDB;
        private RichTextBox enteredInfo;
        private Label label6;
        private Button saveInFile;
        private Label label5;
        private Label successMessage;
    }
}