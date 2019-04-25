using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompostable
    {
        public Guid Id { get; } = Guid.NewGuid();
        private string _shortId {
            get {
                return this.Id.ToString().Substring(this.Id.ToString().Length - 6);
            }
        }
        private double _compostProducedPerField = 3.3;

        public string Type { get; } = "Wildflower";
        public bool InProcess { get; set; }
        public string Product {
            get {
                return "Compost";
            }
        }

        // Methods

        public override string ToString () {
            return $"Wildflower {this._shortId}. Colorful!";
        }

        public double Compose()
        {
            return _compostProducedPerField;
        }
    }
}