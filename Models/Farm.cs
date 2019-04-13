using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();  // TODO: Remove these three for boilerplate
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                // TODO: Boilerplate code and remove line below... case "Cow":
                case "Trestlebridge.Interfaces.IGrazing":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        // TODO: Remove all Add* methods except grazing fields for boilerplate

        public void AddChickenHouse (ChickenHouse house)
        {
            ChickenHouses.Add(house);
        }

        public void AddDuckHouse (DuckHouse house)
        {
            DuckHouses.Add(house);
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddPlowedField (PlowedField field)
        {
            PlowedFields.Add(field);
        }

        public void AddNaturalField (NaturalField field)
        {
            NaturalFields.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(f => report.Append(f));
            PlowedFields.ForEach(f => report.Append(f));  // TODO: Remove from here down for boilerplate
            NaturalFields.ForEach(f => report.Append(f));
            ChickenHouses.ForEach(f => report.Append(f));
            DuckHouses.ForEach(f => report.Append(f));

            return report.ToString();
        }
    }
}