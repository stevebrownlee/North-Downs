using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Models.Animals {
    public class Cow : IResource, IGrazing, IMeatProducing {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 18.25;

        public double GrassPerDay { get; set; } = 5.4;
        public string Product { get; } = "Meat";

        public string Type { get; } = "Cow";

        // Methods
        public void Graze () {
            Console.WriteLine($"Cow {_id} just ate {this.GrassPerDay}kg grass");
        }

        public double Butcher () {
            return _meatProduced;
        }

        public override string ToString () {
            return $"Cow {_id}. Mooo!";
        }
    }
}