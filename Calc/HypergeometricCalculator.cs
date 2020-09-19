using System.Threading.Tasks;
using Hypergeometric.API.Dtos;

namespace Hypergeometric.API.Calc
{
    public class HypergeometricCalculator : IHypergeometricCalculator
    {
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

            return new ResultsDto{ExactlyOne = exactlyOne, AtLeastOne = atLeastOne, OneOrLess = oneOrLess, ExactlyZero = exactlyZero};
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