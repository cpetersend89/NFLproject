using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    class Quarterback : Player
    {
        private double _passingPercentage { get; set; }
        private double _passerRating { get; set; }
        private double _touchDowns { get; set; }
        public Quarterback()
        {

        }
        public Quarterback(string _name, int _age, double _weight, string _position, double _overallrating)
        {
            this.Name = _name;
            this.Age = _age;
            this.Weight = _weight;
            this.Position = _position;
            this.OverallRating = _overallrating;
        }
        public double PassingPercentage
        {
            get { return this._passingPercentage; }
            set { this._passingPercentage = value; }
        }
        public double PasserRating
        {
            get { return this._passerRating; }
            set { this._passerRating = value; }
        }
        public double TouchDowns
        {
            get { return this._touchDowns; }
            set { this._touchDowns = value; }
        }
        
        public void CalcPlayerStats(double statone, double stattwo, double statthree)
        {
            Quarterback quarterback = new Quarterback();
            quarterback.PassingPercentage = statone;
            quarterback.PasserRating = stattwo;
            quarterback.TouchDowns = statthree;
            double averagestats = CalcOverallRating(quarterback.PassingPercentage, quarterback.PasserRating, quarterback.TouchDowns);
        }
        
        public void MakeQuarterbackList()
        {
            
        }
        public override void PlayerInAction()
        {
            Console.WriteLine("Passes");
        }
    }
}
