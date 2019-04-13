using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Interfaces
{
    public interface IEggProducing
    {
        string Product { get; }
        double Process (EggGatherer equipment);
    }
}