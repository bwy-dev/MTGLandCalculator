using System;
using System.Collections.Generic;

namespace Hypergeometric.API.Cards.Interfaces
{
    public abstract class Card
    {
        public string Name { get; set; }
        public bool Untapped { get; set; }
        public bool IsBasic { get; set; }
        public LandColor[] Colors { get; set; }
        public LandType[] LandTypes { get; set; }

        
        ///<summary>Delegate for checking to see if a card has a particular property</summary>
        ///<example>(card) => return card.Name == "Mountain"</example>
        ///<example>(card) => return card.Untapped</example>
        ///<returns>true if the card has the desired property, otherwise false.</returns>
        public delegate bool SearchProperty(Card card);

        ///<summary>Returns a subset of a given list of cards that match a given search property.</summary>
        public static List<Card> FindCardWherePropertyEquals(List<Card> cards, SearchProperty searchProperty)
        {
            List<Card> ret = new();
            for (int i = 0; i < cards.Count; i++)
            {
                if(searchProperty(cards[i]))
                {
                    ret.Add(cards[i]);
                }
            }
            return ret;
        }
    }
}