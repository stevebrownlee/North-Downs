using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility
    {
        private int _capacity = 50;

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
            }
        }

        public void AddResource (List<IGrazing> animals)
        {
            if (_animals.Count + animals.Count <= _capacity) {
                _animals.AddRange(animals);
            }
        }

        public void AddResource()
        {
            throw new System.NotImplementedException();
        }
    }
}