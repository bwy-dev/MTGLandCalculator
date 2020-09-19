using System.Collections.Generic;
using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Cards.CardTypes
{
    public class FetchLand : ICard, IFetchLand
    {
        
        public string Name { get; set; }
        public bool Untapped { get; set; }
        public bool IsBasic { get; set; }
        public bool CanOnlyFetchBasics { get; set; }
        public bool FetchedEntersUntapped { get; set; }
        public LandColor[] Colors { get; set; }
        public LandType[] LandTypes { get; set; }
        public LandType[] FetchableTypes { get; set; }

        public FetchLand(string name, bool untapped, bool isBasic, bool canOnlyFetchBasics, bool fetchedEntersUntapped,
        LandColor[] colors, LandType[] landTypes, LandType[] fetchableTypes)
        {
            this.Name = name;
            this.Untapped = untapped;
            this.IsBasic = isBasic;
            this.CanOnlyFetchBasics = canOnlyFetchBasics;
            this.FetchedEntersUntapped = fetchedEntersUntapped;
            this.Colors = colors;
            this.LandTypes = landTypes;
            this.FetchableTypes = fetchableTypes;

        }
        public List<(LandColor, int)> FetchableColors(List<ICard> cards)
        {
            throw new System.NotImplementedException();
        }

    }
}