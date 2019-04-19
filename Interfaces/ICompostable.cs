using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Interfaces
{
    public interface ICompostable : IResource
    {
        string Product { get; }
        double Compose ();
    }
}