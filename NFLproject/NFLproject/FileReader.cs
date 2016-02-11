using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    class FileReader
    {
        private string _path;
        public FileReader(string pathName)
        {
            _path = pathName;
        }

        public string ReadFromFile()
        {
            using (FileStream fs = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
