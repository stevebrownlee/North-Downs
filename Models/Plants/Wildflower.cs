using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompostable
    {
        private Guid _id = Guid.NewGuid();
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private double _compostProducedPerField = 3.3;

        public string Type { get; } = "Wildflower";

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