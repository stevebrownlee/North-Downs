using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class EggGatherer : Processor, IEquipment
    {
        public string Name { get; } = "Egg gatherer";

        public EggGatherer () {
            Capacity = 15;
            Resources = new List<IResource>();
        }

        public override void ProcessResources ()
        {
            Resources.ForEach(animal => {
                IEggProducing resource = (IEggProducing)animal;
                System.Console.WriteLine($"{resource.Gather()} eggs were produced");
            });
        }
    }
}
