namespace Hypergeometric.API.Dtos
{
    public class ResultsDto
    {
        public decimal AtLeastOne { get; set; }
        public decimal ExactlyOne { get; set; }
        public decimal OneOrLess { get; set; }
        public decimal ExactlyZero { get; set; }

        public ResultsDto(){}
    }
}