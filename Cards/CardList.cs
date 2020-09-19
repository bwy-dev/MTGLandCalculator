using System;
using System.Collections.Generic;
using System.Reflection;
using Hypergeometric.API.Cards.CardTypes;
using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Cards
{
    internal static class CardList
    {
        private static BasicLand Plains = new BasicLand("Plains",true,true,new LandColor[]{LandColor.W}, new LandType[]{LandType.Plains});
        private static BasicLand Island = new BasicLand("Island",true,true,new LandColor[]{LandColor.U}, new LandType[]{LandType.Island});
        private static BasicLand Swamp = new BasicLand("Swamp",true,true,new LandColor[]{LandColor.B}, new LandType[]{LandType.Swamp});
        private static BasicLand Forest = new BasicLand("Forest",true,true,new LandColor[]{LandColor.G}, new LandType[]{LandType.Forest});
        private static BasicLand Mountain = new BasicLand("Mountain",true,true,new LandColor[]{LandColor.R}, new LandType[]{LandType.Mountain});
        private static BasicLand SnowCoveredPlains = new BasicLand("Snow Covered Plains",true,true,new LandColor[]{LandColor.W}, new LandType[]{LandType.Plains});
        private static BasicLand SnowCoveredIsland = new BasicLand("Snow Covered Island",true,true,new LandColor[]{LandColor.U}, new LandType[]{LandType.Island});
        private static BasicLand SnowCoveredSwamp = new BasicLand("Snow Covered Swamp",true,true,new LandColor[]{LandColor.B}, new LandType[]{LandType.Swamp});
        private static BasicLand SnowCoveredForest = new BasicLand("Snow Covered Forest",true,true,new LandColor[]{LandColor.G}, new LandType[]{LandType.Forest});
        private static BasicLand SnowCoveredMountain = new BasicLand("Snow Covered Mountain",true,true,new LandColor[]{LandColor.R}, new LandType[]{LandType.Mountain});
    }

    public static class Cards
    {
        private static List<Card> FullCardList{get;set;}

        public static List<Card> PopulateCardList()
        {
            List<Card> ret = new ();

            Type t = typeof(CardList);
            PropertyInfo[] propInfo = t.GetProperties();

            for (int i = 0; i < propInfo.Length; i++)
            {
                ret.Add(propInfo[i].GetValue(null,null) as Card);
            }

            FullCardList = ret;
            return ret;
        }

    }
}