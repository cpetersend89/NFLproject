using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    class FileReader : IRead
    {
        public void ReadFile(string path)
        {
            string line;
            using (StreamReader _streamreader = new StreamReader(path))
            {
                line = _streamreader.ReadLine();
            }
            Console.WriteLine();
        }
    }
}
