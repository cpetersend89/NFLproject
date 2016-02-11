using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    class FileWriter : IWrite
    {
        public void WriteToFile(string path, List<Roster> WriteRoster)
        {
            using (StreamWriter _streamwriter = new StreamWriter(path))
            {
                foreach (Roster roster in WriteRoster)
                {
                    _streamwriter.WriteLine(roster);
                }
            }
        }
    }
}
