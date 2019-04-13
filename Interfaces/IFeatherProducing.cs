using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Interfaces
{
    public interface IFeatherProducing
    {
        string Product { get; }
        double Process (FeatherHarvester equipment);
    }
}