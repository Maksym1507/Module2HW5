using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Interfaces
{
    public interface IDirectoryConfigurationService
    {
        public void SerializeDirectory(string filePath);

        public string DeserializeDirectory(string filePath);
    }
}
