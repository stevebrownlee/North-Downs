using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class EggGatherer : Processor<IEggProducing>
    {
        public string Name { get; } = "Egg gatherer";

        public List<IEggProducing> _animals { get; } = new List<IEggProducing>();

        public EggGatherer () {
            Capacity = 15;
        }

        public override void ProcessResources ()
        {
            _animals.ForEach(animal =>
                System.Console.WriteLine($"{animal.Gather()} eggs were produced")
            );
        }
    }
}
