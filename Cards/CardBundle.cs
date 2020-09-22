using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Cards
{
    public class CardBundle
    {
        public CardBundle(Card cardDetails, int num)
        {
            CardDetails = cardDetails;
            Num = num;
        }

        public Card CardDetails {get;set;}
        public int Num{get;set;}
    }
}