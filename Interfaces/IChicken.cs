using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
    public interface IChicken: IResource, IFeatherProducing, IMeatProducing, IEggProducing
    {
    }
}