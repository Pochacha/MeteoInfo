namespace MeteoInfo
{
    internal class Settings
    {
        public string[] Options { get; private set; } = new string[4];
        public string Path { get; private set; }
        public static Settings? Instance { get; private set; }           
        public static Settings GetInstance()                           
        {
            if (Instance == null)
            {
                Instance = new Settings();
            }
            return Instance;
        }
        public Settings()                      
        {
            Path = "programSettings.txt";
            if (File.Exists(Path) == false)
            {
                using (FileStream fileStream = new FileStream(Path, FileMode.Create)) { }
            }
            string textFromFile;
            if ((textFromFile = File.ReadAllText(Path)).Trim().Length == 0)
            {
                using (StreamWriter streamWriter = new StreamWriter(Path))
                {
                    streamWriter.WriteLine("Сохранить в файл, Вывести отчет, Сохранить в БД.");
                    streamWriter.WriteLine(Directory.GetCurrentDirectory());
                    streamWriter.WriteLine(".txt");
                    streamWriter.WriteLine("Data Source=MeteoData.db");
                }
            }
            using (StreamReader streamReader = new StreamReader(Path))
            {
                for (int i = 0; (textFromFile = streamReader.ReadLine()!) != null; i++)
                {
                    Options[i] = textFromFile;
                }
            }
        }
    }
}
