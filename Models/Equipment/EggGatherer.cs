using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class EggGatherer : IEquipment
    {
        public double Capacity { get; } = 22;

        public string Name { get; } = "Egg gatherer";

        public List<IEggProducing> _animals { get; } = new List<IEggProducing>();

        public void ProcessResources ()
        {
            _animals.ForEach(animal =>
                System.Console.WriteLine($"{animal.Gather()} eggs were produced")
            );
        }
    }
}
