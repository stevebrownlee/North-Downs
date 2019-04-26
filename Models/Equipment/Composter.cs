using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Equipment
{

    public class Composter : Processor, IEquipment
    {
        public string Name { get; } = "Composter";

        public Composter () {
            Capacity = 8;
            Resources = new List<IResource>();
        }

        public override void ProcessResources ()
        {
            Resources.ForEach(plant => {
                ICompostable resource = (ICompostable)plant;
                System.Console.WriteLine($"{resource.Compose()} eggs were produced");
            });
        }

    }
}