using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    class FileWriter
    {
        private string Path;
        public FileWriter(string _path)
        {
            Path = _path;
        }
        public void WriteToFile(string text)
        {
            using (FileStream fs = new FileStream(Path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(text);
                }
            }
        }
    }
}
