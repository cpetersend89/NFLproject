using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLproject
{
    class WideReceiver : Player
    {
        private double _receptions { get; set; }
        private double _receivingYards { get; set; }
        private double _receivingTouchdowns { get; set; }
        public WideReceiver()
        {

        }
        public WideReceiver(string _name, int _age, double _weight, string _position, double _overallrating)
        {
            this.Name = _name;
            this.Age = _age;
            this.Weight = _weight;
            this.Position = _position;
            this.OverallRating = _overallrating;
        }
        public double Receptions
        {
            get { return this._receptions; }
            set { this._receptions = value; }
        }
        public double ReceivingYards
        {
            get { return this._receivingYards; }
            set { this._receivingYards = value; }
        }
        public double ReceivingTouchdowns
        {
            get { return this._receivingTouchdowns; }
            set { this._receivingTouchdowns = value; }
        }
        public double CalcPlayerStats(double statone, double stattwo, double statthree)
        {
            WideReceiver widereceiver = new WideReceiver();
            widereceiver.Receptions = statone;
            widereceiver.ReceivingYards = stattwo;
            widereceiver.ReceivingTouchdowns = statthree;
            double averagestats = CalcOverallRating(widereceiver.Receptions, widereceiver.ReceivingYards, widereceiver.ReceivingTouchdowns);
            return averagestats;
        }
        public override void PlayerInAction()
        {
            Console.WriteLine("Reception");
        }
    }
}
