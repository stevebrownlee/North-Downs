using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Equipment
{
    public class Processor<T> : IEquipment<T>
    {
        public double Capacity { get; protected set; }

        public List<T> Resources { get; set; }

        public virtual void ProcessResources () {

        }
    }
}