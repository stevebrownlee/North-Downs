using System;

namespace Trestlebridge.Interfaces
{
    public interface IResource
    {
        Guid Id { get; }
        string Type { get; }
        bool InProcess { get; set; }
    }
}