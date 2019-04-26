using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;
        public Guid Id { get; } = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public List<IGrazing> Resources {
            get {
                return _animals;
            }
        }


        public void DiscardResource (int index)
        {
            _animals.RemoveAt(index);
        }

        public void AddResource (IGrazing animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
            }
        }

        public void AddResource (List<IGrazing> animals)  // TODO: Take out this method for boilerplate
        {
            if (_animals.Count + animals.Count <= _capacity) {
                _animals.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this.Id.ToString().Substring(this.Id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}