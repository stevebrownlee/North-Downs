using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IFacility<T>
    {
        double Capacity { get; }

        List<T> Resources { get; }

        void AddResource (T resource);
        void AddResource (List<T> resources);
    }
}