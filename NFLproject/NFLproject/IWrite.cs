using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    interface IWrite
    {
        void WriteToFile(string path, List<Roster> WriteRoster);
    }
}
