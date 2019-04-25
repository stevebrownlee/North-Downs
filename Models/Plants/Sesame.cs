using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IResource, ISeedProducing
    {
        private int _seedsProduced = 40;
        private string _shortId {
            get {
                return this.Id.ToString().Substring(this.Id.ToString().Length - 6);
            }
        }

        public Guid Id { get; } = Guid.NewGuid();
        public string Type { get; } = "Sesame";
        public bool InProcess { get; set; }

        // Methods
        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sesame {this._shortId}. Yum!";
        }

    }
}