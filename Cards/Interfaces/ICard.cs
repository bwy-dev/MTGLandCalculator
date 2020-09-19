using System.Collections.Generic;

namespace Hypergeometric.API.Cards.Interfaces
{
    public interface ICard
    {
        string Name { get; set; }
        bool Untapped { get; set; }
        bool IsBasic { get; set; }
        LandColor[] Colors { get; set; }
        LandType[] LandTypes { get; set; }

    }
}