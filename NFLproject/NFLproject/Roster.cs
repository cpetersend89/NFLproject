using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    class Roster
    {

        public Roster()
        {

        }
        List<Player> PlayerOptions = new List<Player>();
        public void MakePlayersList()
        {
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("J.J. Watt", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));
            PlayerOptions.Add(new Player("Aaron Rodgers", 32, 196.5, "quarterback", 8.2));

        }
        public double CalcAverageRating(double overallrating, int numofplayers)
        {
            double AverageRating;
            AverageRating = overallrating / numofplayers;
            return AverageRating;
        }
        public int CalcAverageAge(int totalage, int numberofplayers)
        {
            int AverageAge;
            AverageAge = totalage / numberofplayers;
            return AverageAge;
        }
        public double CalcAverageWeight(double totalweight, int numberofplayers)
        {
            double AverageWeight;
            AverageWeight = totalweight / numberofplayers;
            return AverageWeight;
        }
    }
}
