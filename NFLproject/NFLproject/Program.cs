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
            Quarterback test = new Quarterback();
            test.CalcPlayerStats(12.2, 15.3, 10.5);
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
