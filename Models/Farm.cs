using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Equipment;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();  // TODO: Remove these three for boilerplate
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        public SeedHarvester SeedHarvester { get; set; } = new SeedHarvester();
        public Composter Composter { get; set; } = new Composter();
        public EggGatherer EggGatherer { get; set; } = new EggGatherer();
        public MeatProcessor MeatProcessor { get; set; } = new MeatProcessor();
        public FeatherHarvester FeatherHarvester { get; set; } = new FeatherHarvester();

        public Farm () {
            this.GrazingFields.Add(new GrazingField());
            this.GrazingFields[0].AddResource(new Cow());
            this.GrazingFields[0].AddResource(new Cow());
            this.GrazingFields[0].AddResource(new Cow());
            this.GrazingFields[0].AddResource(new Ostrich());


            this.PlowedFields.Add(new PlowedField());
            this.PlowedFields.Add(new PlowedField());
            this.PlowedFields.Add(new PlowedField());

            this.PlowedFields[0].AddResource(new Sesame());
            this.PlowedFields[0].AddResource(new Sesame());
            this.PlowedFields[0].AddResource(new Sesame());
            this.PlowedFields[1].AddResource(new Sesame());
            this.PlowedFields[1].AddResource(new Sesame());
            this.PlowedFields[2].AddResource(new Sesame());

            this.DuckHouses.Add(new DuckHouse());
            this.DuckHouses[0].AddResource(new Duck());

            this.ChickenHouses.Add(new ChickenHouse());
            this.ChickenHouses.Add(new ChickenHouse());

            this.ChickenHouses[0].AddResource(new Chicken());
            this.ChickenHouses[0].AddResource(new Chicken());


            this.NaturalFields.Add(new NaturalField());
            this.NaturalFields.Add(new NaturalField());

        }

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Trestlebridge.Interfaces.IGrazing":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

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

            GrazingFields.ForEach(gf => report.Append(gf));
            PlowedFields.ForEach(pf => report.Append(pf));
            NaturalFields.ForEach(nf => report.Append(nf));
            ChickenHouses.ForEach(ch => report.Append(ch));
            DuckHouses.ForEach(dh => report.Append(dh));

            return report.ToString();
        }
    }
}