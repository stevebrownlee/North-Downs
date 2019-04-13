using Trestlebridge.Models.Equipment;

namespace Trestlebridge.Interfaces
{
    public interface ISeedProducing : IResource
    {
        double Harvest ();
    }
}