using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IResource, ISeedProducing
    {
        private Guid _id = Guid.NewGuid();
        private int _seedsProduced = 40;
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Sesame";

        // Methods
        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sesame {this._shortId}. Yum!";
        }

    }
}