namespace MeteoInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Record? rec;
        Settings Settings = Settings.GetInstance();
        
        public void SuccessAndClose()
        {
            successMessage.Visible = true;
            Task.Delay(5000).GetAwaiter().GetResult();
            Close();
        }

        private void enterData_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTemp.Text) || String.IsNullOrEmpty(comboBoxWeather.Text))
            {
                MessageBox.Show("������� ������!");
            }
            else
            {
                if (int.TryParse(textBoxTemp.Text, out int number))
                {
                    rec = new Record(textBoxTemp.Text, comboBoxWeather.Text, textBoxNote.Text, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("�������� ����������� ������� �������!");
                }
            }

        }

        private void printInfo_Click(object sender, EventArgs e)
        {
            if (rec != null && String.IsNullOrEmpty(textBoxTemp.Text) == false && String.IsNullOrEmpty(comboBoxWeather.Text) == false)
            {
                if (rec.Note == "")
                {
                    enteredInfo.Text = $"����: {rec.Date}\n�����������: {rec.Temp}\n������: {rec.State}\n";
                }
                else
                {
                    enteredInfo.Text = $"����: {rec.Date}\n�����������: {rec.Temp}\n������: {rec.State}\n�������: {rec.Note}";
                }
                SuccessAndClose();
            }
            else
            {
                MessageBox.Show("������� ������!");
            }
        }

        private void SaveInFile_Click(object sender, EventArgs e)
        {
            if (rec != null && String.IsNullOrEmpty(textBoxTemp.Text) == false && String.IsNullOrEmpty(comboBoxWeather.Text) == false)
            {
                if (rec.SaveInFile(Settings))
                {
                    label5.Visible = true;
                    labelPath.Text = Settings.Options[1] + $@"\record {DateTime.Now.ToString().Replace(":", " ")}{Settings.Options[2].Trim()}";
                    SuccessAndClose();
                }
            }
            else
            {
                MessageBox.Show("������� ������!");
            }
        }

        private void textBoxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)8 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void saveInDB_Click(object sender, EventArgs e)
        {
            if (rec != null && String.IsNullOrEmpty(textBoxTemp.Text) == false && String.IsNullOrEmpty(comboBoxWeather.Text) == false)
            {
                using (AppContext db = new AppContext(Settings))
                {
                    db.Database.EnsureCreated();
                    if (rec != null)
                    {
                        db.WeatherData.Add(rec);
                    }
                    db.SaveChanges();
                    SuccessAndClose();
                }
            }
            else
            {
                MessageBox.Show("������� ������!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var buttons = new Dictionary<string, Button>
            {
                {"��������� � ����",  saveInFile},
                {"������� �����", printInfo },
                {"��������� � ��", saveInDB }
            };
            foreach (var button in buttons)
            {
                if (Settings.Options[0].Contains(button.Key)) button.Value.Enabled = true;
            }
        }
    }
}