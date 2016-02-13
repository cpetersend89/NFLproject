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
            using (FileStream filestream = new FileStream(Path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamwriter = new StreamWriter(filestream))
                {
                    streamwriter.WriteLine(text);
                }
            }
        }
    }
}
