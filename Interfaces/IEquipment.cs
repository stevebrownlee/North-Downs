using System.Collections.Generic;

namespace Trestlebridge.Interfaces
{
    public interface IEquipment<T>
    {
        double Capacity { get; }
        List<T> Resources { get; set; }

        void ProcessResources ();
    }
}