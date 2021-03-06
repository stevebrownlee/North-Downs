using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
    public class NaturalField {
        private int _capacity = 145;
        public Guid Id {get;} = Guid.NewGuid ();

        private List<ICompostable> _plants = new List<ICompostable> ();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (ICompostable plant) {
            if (_plants.Count < _capacity) {
                _plants.Add (plant);
            }
        }

        public void AddResource (List<ICompostable> plants) // TODO: Take out this method for boilerplate
        {
            if (_plants.Count + plants.Count <= _capacity) {
                _plants.AddRange (plants);
            }
        }

        public override string ToString () {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this.Id.ToString().Substring(this.Id.ToString().Length - 6)}";

            output.Append ($"Natural field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();
        }
    }
}