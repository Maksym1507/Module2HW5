using System.IO;
using Module2HW5.Configs;
using Module2HW5.Interfaces;
using Newtonsoft.Json;

namespace Module2HW5.Services
{
    public class DirectoryConfigurationService : IDirectoryConfigurationService
    {
        public DirectoryConfigurationService()
        {
            Directory = new DirectoryConfiguration();
        }

        private DirectoryConfiguration Directory { get; }

        public void SerializeDirectory(string jsonFile)
        {
            var stringJsonFile = JsonConvert.SerializeObject(Directory.Path);
            File.WriteAllText(jsonFile, stringJsonFile);
        }

        public string DeserializeDirectory(string jsonFile)
        {
            SerializeDirectory(jsonFile);
            var configFile = File.ReadAllText(jsonFile);
            return JsonConvert.DeserializeObject<string>(configFile);
        }
    }
}
