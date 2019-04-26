using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class SeedHarvester : Processor
    {
        public string Name { get; } = "Seed harvester";

        public SeedHarvester () {
            Capacity = 15;
        }

        public override void ProcessResources (Farm farm)
        {
            System.Console.WriteLine("Processing resources...");
            Resources.ForEach(id =>
                farm.PlowedFields.ForEach(f => r.Id));
            //     System.Console.WriteLine($"{animal.Harvest()} seeds were produced")
            // );
        }
    }
}
