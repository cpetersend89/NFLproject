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
            Roster test = new Roster();
            test.MakePlayersList();
            test.WriteRoster(@"../../Test.txt");
            test.ReadRoster(@"../../Test.txt");

            Console.ReadLine();
        }
    }
}
