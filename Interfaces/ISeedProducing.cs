using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Interfaces
{
    public interface ISeedProducing
    {
        string Product { get; }
        double Process (SeedHarvester equipment);
    }
}