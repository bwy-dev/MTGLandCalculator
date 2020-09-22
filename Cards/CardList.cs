using System;
using System.Collections.Generic;
using System.Reflection;
using Hypergeometric.API.Cards.CardTypes;
using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Cards
{
    internal static class CardList
    {
        #region Basic Lands
        public static BasicLand Plains { get { return new BasicLand("Plains", true, true, new LandColor[] { LandColor.W }, new LandType[] { LandType.Plains });}}
        public static BasicLand Island { get { return new BasicLand("Island", true, true, new LandColor[] { LandColor.U }, new LandType[] { LandType.Island }); } }
        public static BasicLand Swamp {get { return new BasicLand("Swamp", true, true, new LandColor[] { LandColor.B }, new LandType[] { LandType.Swamp });}}
        public static BasicLand Forest {get { return new BasicLand("Forest", true, true, new LandColor[] { LandColor.G }, new LandType[] { LandType.Forest });}}
        public static BasicLand Mountain {get { return new BasicLand("Mountain", true, true, new LandColor[] { LandColor.R }, new LandType[] { LandType.Mountain });}}
        public static BasicLand SnowCoveredPlains {get { return new BasicLand("Snow Covered Plains", true, true, new LandColor[] { LandColor.W }, new LandType[] { LandType.Plains });}}
        public static BasicLand SnowCoveredIsland {get { return new BasicLand("Snow Covered Island", true, true, new LandColor[] { LandColor.U }, new LandType[] { LandType.Island });}}
        public static BasicLand SnowCoveredSwamp {get { return new BasicLand("Snow Covered Swamp", true, true, new LandColor[] { LandColor.B }, new LandType[] { LandType.Swamp });}}
        public static BasicLand SnowCoveredForest {get { return new BasicLand("Snow Covered Forest", true, true, new LandColor[] { LandColor.G }, new LandType[] { LandType.Forest });}}
        public static BasicLand SnowCoveredMountain {get { return new BasicLand("Snow Covered Mountain", true, true, new LandColor[] { LandColor.R }, new LandType[] { LandType.Mountain });}}
        #endregion
        
        #region Fetch Lands
        public static FetchLand FloodedStrand {get { return new FetchLand("Flooded Strand", true, false, false, true, new LandColor[] { LandColor.W, LandColor.U }, null, new LandType[] { LandType.Island, LandType.Plains });}}
        #endregion
    }

    public static class Cards
    {
        public static List<Card> FullCardList { get; private set; }

        public static List<Card> PopulateCardList()
        {
            List<Card> ret = new List<Card>();

            Type t = typeof(CardList);
            PropertyInfo[] propInfo = t.GetProperties();

            for (int i = 0; i < propInfo.Length; i++)
            {
                ret.Add(propInfo[i].GetValue(null, null) as Card);
            }

            FullCardList = ret;
            return ret;
        }

    }
}