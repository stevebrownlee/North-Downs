using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class MeatProcessor : IEquipment
    {
        public double Capacity { get; } = 22;

        public List<IMeatProducing> _animals { get; } = new List<IMeatProducing>();

        public void ProcessResources ()
        {
            _animals.ForEach(animal =>
                System.Console.WriteLine($"{animal.Process()}kg of {animal.Product} was produced")
            );
        }
    }
}
