using System.Collections.Generic;

namespace Trestlebridge.Interfaces
{
    public interface IEquipment
    {
        double Capacity { get; }
        List<IResource> Resources { get; set; }

        void ProcessResources ();
    }
}