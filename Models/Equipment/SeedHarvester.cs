using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class SeedHarvester : Processor
    {
        public string Name { get; } = "Seed harvester";

        public SeedHarvester () {
            Capacity = 15;
            Resources = new List<IResource>();
        }

        public override void ProcessResources ()
        {
            System.Console.WriteLine("Processing resources...");
            Resources.ForEach(resource => {
                ISeedProducing seedingPlant = (ISeedProducing)resource;
                System.Console.WriteLine($"{seedingPlant.Harvest()} seeds were produced");
            });
        }
    }
}
