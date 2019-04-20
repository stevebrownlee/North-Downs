using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Models.Plants {
    public class Sunflower : IResource, ISeedProducing, ICompostable {

        private Guid _id = Guid.NewGuid();
        private int _seedsProduced = 150;
        private double _compostProduced = 21.6;
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Sunflower";

        public string Product => "Compost";

        // Methods
        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower {this._shortId}. Shine!";
        }

        public double Compose()
        {
            return this._compostProduced;
        }
    }
}