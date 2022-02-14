using System;
using System.IO;
using Module2HW5.Interfaces;

namespace Module2HW5.Services
{
    public class FileService : IFileService
    {
        public FileService(IDirectoryConfigurationService directoryConfigurationService)
        {
            DirectoryConfigurationService = directoryConfigurationService;
        }

        private IDirectoryConfigurationService DirectoryConfigurationService { get; set; }

        public void WriteToFile(string log)
        {
            string directoryPath = DirectoryConfigurationService.DeserializeDirectory("config.json");

            string[] files = Directory.GetFiles(directoryPath);

            if (Directory.GetFiles(directoryPath).Length > 3)
            {
                string oldFile = files[0];

                for (int i = 0; i < files.Length; i++)
                {
                    if (File.GetCreationTime(oldFile) > File.GetCreationTime(files[i]))
                    {
                        oldFile = files[i];
                    }
                }

                File.Delete(oldFile);
            }

            using (var sw = new StreamWriter($@"{directoryPath}\{DateTime.Now:HH.mm.ss dd.MM.yyyy}.txt", true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(log);
            }
        }
    }
}
