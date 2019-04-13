namespace Trestlebridge.Interfaces
{
    public interface IEquipment
    {
        double Capacity { get; }

        void ProcessResources ();
    }
}