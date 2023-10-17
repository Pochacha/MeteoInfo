namespace MeteoInfo
{
    internal class Record
    {
        public int Id { get; private set; }
        public string Temp { get; private set; }
        public string State { get; private set; }
        public string Note { get; private set; }
        public DateTime Date { get; private set; }
        public Record(string temp, string state, string note, DateTime date)
        {
            if (String.IsNullOrEmpty(temp) || String.IsNullOrEmpty(state))
            {
                MessageBox.Show("Введите данные!");
            }
            Temp = temp;
            State = state;
            Note = note;
            Date = date;
        }

        public bool SaveInFile(Settings Settings)
        {
            try
            {
                if (Note != "")
                {
                    File.AppendAllText($@"{Settings.Options[1].Trim()}\record {DateTime.Now.ToString().Replace(":", " ")}{Settings.Options[2].Trim()}", $"{Temp} {State} {Note} {Date}");
                }
                else
                {
                    File.AppendAllText($@"{Settings.Options[1].Trim()}\record {DateTime.Now.ToString().Replace(":", " ")}{Settings.Options[2].Trim()}", $"{Temp} {State} {Date}");
                }
                return true;
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Путь к файлу указан некорректно!");
                return false;
            }
        }
    }
}
