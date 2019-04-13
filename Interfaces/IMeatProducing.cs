using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Interfaces
{
    public interface IMeatProducing
    {
        string Product { get; }
        double Butcher ();
    }
}