using System.Collections.Generic;
using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Cards.CardTypes
{
    public class BasicLand : Card
    {
        
        public BasicLand(string name, bool untapped, bool isBasic, LandColor[] colors, LandType[] landTypes)
        {
            this.Name = name;
            this.Untapped = untapped;
            this.IsBasic = isBasic;
            this.LandTypes = landTypes;
            this.Colors = colors;

        }

    }
}