using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class MeatProcessor : IEquipment
    {
        public double Capacity { get; } = 22;

        public string Name { get; } = "Meat processor";

        public List<IMeatProducing> _animals { get; } = new List<IMeatProducing>();

        public void ProcessResources ()
        {
            _animals.ForEach(animal =>
                System.Console.WriteLine($"{animal.Butcher()}kg of {animal.Product} was produced")
            );
        }
    }
}
