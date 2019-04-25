using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class MeatProcessor : Processor<IMeatProducing>
    {
        public string Name { get; } = "Meat processor";

        public List<IMeatProducing> _animals { get; } = new List<IMeatProducing>();

        public MeatProcessor () {
            Capacity = 22;
        }

        public override void ProcessResources ()
        {
            _animals.ForEach(animal =>
                System.Console.WriteLine($"{animal.Butcher()}kg of meat was produced")
            );
        }
    }
}
