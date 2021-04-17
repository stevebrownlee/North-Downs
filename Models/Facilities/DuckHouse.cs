using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IMeatProducer<Duck>
    {
        private int _capacity = 12;

        public Guid Id { get; } = Guid.NewGuid();

        private List<Duck> _animals = new List<Duck>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public List<Duck> Resources {
            get {
                return _animals;
            }
        }

        public void DiscardResource (int index)
        {
            _animals.RemoveAt(index);
        }

        public void AddResource (Duck animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
            }
        }

        public void AddResource (List<Duck> animals)
        {
            if (_animals.Count + animals.Count <= _capacity) {
                _animals.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this.Id.ToString().Substring(this.Id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}