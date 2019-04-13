using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Interfaces
{
    public interface ICompostable
    {
        string Product { get; }
        double Compose ();
    }
}