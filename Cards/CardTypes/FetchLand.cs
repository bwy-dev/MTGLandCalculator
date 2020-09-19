using System.Collections.Generic;
using System.Linq;
using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Cards.CardTypes
{
    public class FetchLand : Card, IFetchLand
    {
        
        public bool CanOnlyFetchBasics { get; set; }
        public bool FetchedEntersUntapped { get; set; }
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
        public List<LandColor> FetchableColors(List<Card> cards)
        {
            List<Card> fetchableCards = Card.FindCardWherePropertyEquals(cards, (c) =>{
                return c.LandTypes.Contains(FetchableTypes[0]) || c.LandTypes.Contains(FetchableTypes[1]);
            });

            List<LandColor[]> colors = fetchableCards.Select(o => o.Colors).ToList();

            List<LandColor> ret = new();
            foreach(LandColor[] colorArr in colors)
            {
                for (int i = 0; i < colorArr.Length; i++)
                {
                    ret.Add(colorArr[i]);
                }
            }

            return ret.Distinct().ToList();
        }

    }
}