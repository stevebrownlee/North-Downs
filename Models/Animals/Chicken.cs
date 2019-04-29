using System;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Animals {
    public class Chicken : IChicken {

        private double _meatProduced = 1.7;
        private int _eggsProduced = 7;
        private double _feathersProduced = 0.5;
        private string _shortId {
            get {
                return this.Id.ToString ().Substring (this.Id.ToString ().Length - 6);
            }
        }

        public Guid Id { get; } = Guid.NewGuid ();

        public string Type { get; } = "Chicken";

        public bool InProcess { get; set; }

        public double Butcher () {
            return _meatProduced;
        }

        public double Gather () {
            return _eggsProduced;
        }

        public double Pluck () {
            return _feathersProduced;
        }

        public override string ToString () {
            return $"{this.Type} {this._shortId}. Bawk!";
        }
    }
}