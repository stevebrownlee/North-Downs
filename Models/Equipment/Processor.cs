using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Equipment
{
    public class Processor : IEquipment
    {
        public double Capacity { get; protected set; }

        public List<Guid> Resources { get; set; } = new List<Guid>();

        public virtual void ProcessResources (Farm farm) {

        }
    }
}