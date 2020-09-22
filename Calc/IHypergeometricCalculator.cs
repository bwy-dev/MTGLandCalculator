using Hypergeometric.API.Dtos;

namespace Hypergeometric.API.Calc
{
    public interface IHypergeometricCalculator
    {
        ResultsDto CalculateProbability(int popSize, int sampleSize, int successesInSample, int successesInPop);
        public ResultsDto ParseDeckList(CalcValuesDto decklist);
    }
}