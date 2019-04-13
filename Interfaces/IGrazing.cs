namespace Trestlebridge.Interfaces
{
    public interface IGrazing : IResource
    {
        double GrassPerDay { get; set; }
        void Graze();
    }
}