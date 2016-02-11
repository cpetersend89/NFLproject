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
            
            RunningBack runningback = new RunningBack();
            WideReceiver widereceiver = new WideReceiver();
            PlayerOptions.Add(new Quarterback("Russell Wilson", 27, 206, "Quarterback", 61.4, 52.3, 26));
            PlayerOptions.Add(new RunningBack("Adrian Patterson", 30, 220, "Runningback", 2381, 11675, 97));
            PlayerOptions.Add(new WideReceiver("Julio Jones", 27, 220, "Wide Receiver", 414, 6201, 34));

            foreach(Player player in PlayerOptions)
            {
                Console.WriteLine(player);
            }

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
