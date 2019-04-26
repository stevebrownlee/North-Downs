using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{
    public class MeatProcessor : Processor, IEquipment
    {
        public string Name { get; } = "Meat processor";

        public MeatProcessor () {
            Capacity = 22;
            Resources = new List<IResource>();
        }

        public override void ProcessResources ()
        {
            Resources.ForEach(animal => {
                IMeatProducing resource = (IMeatProducing)animal;
                System.Console.WriteLine($"{resource.Butcher()}kg of meat was produced");
            });
        }
    }
}
