using System.Collections.Generic;
using Hypergeometric.API.Cards;
using Hypergeometric.API.Cards.Interfaces;

namespace Hypergeometric.API.Dtos
{
    public class ResultsDto
    {
        public List<CardBundle> Cards{get;set;}

        public ResultsDto(){}
    }
}