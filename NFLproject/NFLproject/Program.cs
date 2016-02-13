using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Roster myteam = new Roster();
            myteam.MakePlayersList();
            myteam.WriteRoster(@"../../Roster.txt");
            myteam.ReadRoster(@"../../Roster.txt");

            Console.ReadLine();
        }
    }
}
