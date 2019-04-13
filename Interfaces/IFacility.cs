namespace Trestlebridge.Interfaces
{
    public interface IFacility
    {
        double Capacity { get; }

        void AddResource ();
    }
}