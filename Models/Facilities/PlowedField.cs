using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class PlowedField : IFacility<ISeedProducing>
    {
        private int _capacity = 250;
        public Guid Id { get; } = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public List<ISeedProducing> Resources {
            get {
                return _plants;
            }
        }

        public void DiscardResource (int index)
        {
            _plants.RemoveAt(index);
        }

        public void AddResource (ISeedProducing plant)
        {
            if (_plants.Count < _capacity) {
                _plants.Add(plant);
            }
        }

        public void AddResource (List<ISeedProducing> plants)  // TODO: Take out this method for boilerplate
        {
            if (_plants.Count + plants.Count <= _capacity) {
                _plants.AddRange(plants);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this.Id.ToString().Substring(this.Id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}