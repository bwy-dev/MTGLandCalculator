using Hypergeometric.API.Cards.CardTypes;
using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Cards
{
    public static class CardList
    {
        public static BasicLand Plains = new BasicLand("Plains",true,true,new LandColor[]{LandColor.W}, new LandType[]{LandType.Plains});
        public static BasicLand Island = new BasicLand("Island",true,true,new LandColor[]{LandColor.U}, new LandType[]{LandType.Island});
        public static BasicLand Swamp = new BasicLand("Swamp",true,true,new LandColor[]{LandColor.B}, new LandType[]{LandType.Swamp});
        public static BasicLand Forest = new BasicLand("Forest",true,true,new LandColor[]{LandColor.G}, new LandType[]{LandType.Forest});
        public static BasicLand Mountain = new BasicLand("Mountain",true,true,new LandColor[]{LandColor.R}, new LandType[]{LandType.Mountain});
        public static BasicLand SnowCoveredPlains = new BasicLand("Snow Covered Plains",true,true,new LandColor[]{LandColor.W}, new LandType[]{LandType.Plains});
        public static BasicLand SnowCoveredIsland = new BasicLand("Snow Covered Island",true,true,new LandColor[]{LandColor.U}, new LandType[]{LandType.Island});
        public static BasicLand SnowCoveredSwamp = new BasicLand("Snow Covered Swamp",true,true,new LandColor[]{LandColor.B}, new LandType[]{LandType.Swamp});
        public static BasicLand SnowCoveredForest = new BasicLand("Snow Covered Forest",true,true,new LandColor[]{LandColor.G}, new LandType[]{LandType.Forest});
        public static BasicLand SnowCoveredMountain = new BasicLand("Snow Covered Mountain",true,true,new LandColor[]{LandColor.R}, new LandType[]{LandType.Mountain});
    }
}