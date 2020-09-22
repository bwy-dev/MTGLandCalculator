using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Hypergeometric.API.Cards;
using Hypergeometric.API.Cards.Interfaces;
using Hypergeometric.API.Dtos;

namespace Hypergeometric.API.Calc
{
    public class HypergeometricCalculator : IHypergeometricCalculator
    {
        public ResultsDto ParseDeckList(CalcValuesDto decklist)
        {
            Cards.Cards.PopulateCardList();
            List<CardBundle> cardList = new List<CardBundle>();
            string[] cardNames = decklist.DeckList.Split(System.Environment.NewLine);
            for (int i = 0; i < cardNames.Length; i++)
            {
                int numC = Int32.Parse((new string(cardNames[i].Where(char.IsNumber).ToArray())));

                Card c = Card.FindCardWherePropertyEquals(Cards.Cards.FullCardList, (c) =>{
                    return c.Name == new string(cardNames[i].Where(c => (c < '0' || c > '9')).ToArray()).Trim();
                });

                if(c==null)
                {
                    continue;
                }
                else
                {
                    cardList.Add(new CardBundle(c,numC));
                }
            }

            return new ResultsDto{Cards = cardList};
        }

        public  ResultsDto CalculateProbability(int popSize, int sampleSize, int successesInSample, int successesInPop)
        {
            int N = popSize;
            int K = successesInPop;
            int n = sampleSize;
            int k = successesInSample;

            decimal atLeastOne = 0;
            for(int i = k; i< K; i++)
            {
                atLeastOne += Hypergeometric(N,K,n,i);
            }

            decimal exactlyOne = Hypergeometric(N,K,n,k);

            decimal oneOrLess = 0;
            for(int i = k; i>=0 ; i --)
            {
                oneOrLess += Hypergeometric(N,K,n,i);
            }

            decimal exactlyZero = Hypergeometric(N,K,n,0);
            return null;
        }

        /**
        *<summary>Calculates the Hypergeometric distribution of a sample in a population.</summary>
        *<param name="N">population size</param>
        *<param name="K">number of successes in population </param>
        *<param name="n">sample size </param>
        *<param name="k">number of successes in sample </param>
        */
        private decimal Hypergeometric(int N, int K, int n, int k)
        {
            return (BC(K,k)*BC(N-K,n-k))/ BC(N,n);
        }
        
        /**
        *<summary>Gets the Binomial Coefficient of two integers</summary>
        *<param name="n">population size ("top" value)</param>
        *<param name="k">sample size ("bottom" value)</param>
        *<returns>The binomial coefficient of <paramref name="n"/> and <paramref name="k"/> as a decimal</returns>
        */
        private decimal BC(int n, int k)
        {
            decimal ret = 1;
            for(int i = 1; i<=k; i++)
            {
                ret *= n - (k- i);
                ret /= i;
            }

            return ret;
        }


    }
}