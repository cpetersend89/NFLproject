using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    public class Player
    {
        public string Name;
        public int Age;
        public double Weight;
        public string Position;
        public double OverallRating;
        public Player()
        {

        }
        //public Player(string _name, int _age, double _weight, string _position, double _overallrating)
        //{
        //    this.Name = _name;
        //    this.Age = _age;
        //    this.Weight = _weight;
        //    this.Position = _position;
        //    this.OverallRating = _overallrating;

        //}
        public double CalcOverallRating(double statone, double stattwo, double statthree)
        {
            int numofstats = 3;
            double PlayerOverallRating;
            PlayerOverallRating = (statone + stattwo + statthree) / numofstats;
            return PlayerOverallRating;
        }
        public virtual void PlayerInAction()
        {
            Console.WriteLine("Player Action");
        }
        public override string ToString()
        {
            return Name + " " + Age + " " + Weight + " " + Position + " " + OverallRating;
        }
    }
}
