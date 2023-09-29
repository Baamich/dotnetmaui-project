using System.IO;

namespace project.Models
{
    public class LoginDataFileHandler
    {
        private readonly string fileName;
        private readonly string directory;
        private readonly string filePath;

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
    }
}

