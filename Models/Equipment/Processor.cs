using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Equipment
{
    public class Processor : IEquipment
    {
        public double Capacity { get; protected set; }

        public List<IResource> Resources { get; set; }

        public virtual void ProcessResources () {

        }
    }
}