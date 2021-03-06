using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Models.Animals {
    public class Cow : IResource, IGrazing, IMeatProducing {

        public Guid Id { get; } = Guid.NewGuid();
        private double _meatProduced = 18.25;

        private string _shortId {
            get {
                return this.Id.ToString().Substring(this.Id.ToString().Length - 6);
            }
        }

        public bool InProcess { get; set; }
        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Cow";

        // Methods
        public void Graze () {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher () {
            return _meatProduced;
        }

        public override string ToString () {
            return $"Cow {this._shortId}. Mooo!";
        }
    }
}