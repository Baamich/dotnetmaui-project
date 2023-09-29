using System.IO;

namespace project.Models
{
    public class LoginDataFileHandler
    {
        private readonly string fileName;
        private readonly string directory;
        private readonly string filePath;

        public string emailLine { get; private set; }
        public string passwordLine { get; private set; }

        public LoginDataFileHandler()
        {
            fileName = "LoginDataStoreFile.txt";
            directory = FileSystem.Current.AppDataDirectory;
            filePath = Path.Combine(directory, fileName);            
        }

        public async Task WriteLoginData(string email, string password)
        {                         
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                await writer.WriteAsync($"{email}\n{password}");
            }            
        }

        public async Task ReadLoginData()
        {
            if(emailLine == null || passwordLine == null)
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    int lineToSave = 0;
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        if (lineToSave == 0) emailLine += line;
                        if (lineToSave == 1) passwordLine += line;
                        lineToSave++;
                    }
                }
            }            
        }
    }
}

