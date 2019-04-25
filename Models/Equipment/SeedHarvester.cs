using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class SeedHarvester : Processor<ISeedProducing>
    {
        public string Name { get; } = "Seed harvester";

        public SeedHarvester () {
            Capacity = 15;
        }

        public override void ProcessResources ()
        {
            System.Console.WriteLine("Processing resources...");
            Resources.ForEach(animal =>
                System.Console.WriteLine($"{animal.Harvest()} seeds were produced")
            );
        }
    }
}
