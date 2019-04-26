using System;
using System.Collections.Generic;

namespace Trestlebridge.Interfaces
{
    public interface IEquipment
    {
        double Capacity { get; }
        List<Guid> Resources { get; set; }

        void ProcessResources (Farm farm);
    }
}