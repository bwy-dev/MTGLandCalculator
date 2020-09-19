using System.Collections.Generic;

namespace Hypergeometric.API.Cards.Interfaces
{
    public interface IFetchLand
    {
         bool FetchedEntersUntapped{ get; set; }
         bool CanOnlyFetchBasics{ get; set; }
         LandType[] FetchableTypes { get; set; }
         List<LandColor> FetchableColors(List<Card> cards);
    }
}