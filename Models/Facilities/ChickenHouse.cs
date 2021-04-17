using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IMeatProducer<Chicken>
    {
        private int _capacity = 15;

        public Guid Id { get; } = Guid.NewGuid();

        private List<Chicken> _animals = new List<Chicken>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public List<Chicken> Resources {
            get {
                return _animals;
            }
        }

        public void DiscardResource (int index)
        {
            _animals.RemoveAt(index);
        }

        public void AddResource (Chicken animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
            }
        }

        public void AddResource (List<Chicken> animals)
        {
            if (_animals.Count + animals.Count <= _capacity) {
                _animals.AddRange(animals);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this.Id.ToString().Substring(this.Id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}