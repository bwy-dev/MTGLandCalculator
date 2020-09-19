using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Cards.CardTypes
{
    public class BasicLand : ICard
    {
        
        public string Name { get; set; }
        public bool Untapped { get; set; }
        public bool IsBasic { get; set; }
        public LandColor[] Colors { get; set; }
        public LandType[] LandTypes { get; set; }
        
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