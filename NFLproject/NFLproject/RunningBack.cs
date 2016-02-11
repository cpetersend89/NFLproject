using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{

    class RunningBack : Player
    {
        private double _rushingAttempts { get; set; }
        private double _rushingYards { get; set; }
        private double _rushingTouchdowns { get; set; }
        public RunningBack()
        {

        }

        public RunningBack(string _name, int _age, double _weight, string _position, double _overallrating)
        {
            this.Name = _name;
            this.Age = _age;
            this.Weight = _weight;
            this.Position = _position;
            this.OverallRating = _overallrating;
        }
        public double RushingAttempts
        {
            get { return this._rushingAttempts; }
            set { this._rushingAttempts = value; }
        }
        public double RushingYards
        {
            get { return this._rushingYards; }
            set { this._rushingYards = value; }
        }
        public double RushingTouchdowns
        {
            get { return this._rushingTouchdowns; }
            set { this._rushingTouchdowns = value; }
        }
        public double CalcPlayerStats(double statone, double stattwo, double statthree)
        {
            RunningBack runningback = new RunningBack();
            runningback.RushingAttempts = statone;
            runningback.RushingYards = stattwo;
            runningback.RushingTouchdowns = statthree;
            double averagestats = CalcOverallRating(runningback.RushingAttempts, runningback.RushingYards, runningback.RushingTouchdowns);
            return averagestats;
        }

        public override void PlayerInAction()
        {
            Console.WriteLine("Rushes");
        }
    }
}
