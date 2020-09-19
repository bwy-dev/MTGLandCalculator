using System.Threading.Tasks;
using Hypergeometric.API.Calc;
using Hypergeometric.API.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Hypergeometric.API.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private IHypergeometricCalculator _calculator;
        public CalculatorController(IHypergeometricCalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpPost("calc")]
        public IActionResult Calculate([FromBody] CalcValuesDto calcValuesDto)
        {

            ResultsDto result = _calculator.CalculateProbability(calcValuesDto.PS,calcValuesDto.SS,calcValuesDto.SIS,calcValuesDto.SIP);
            return Ok(result);
        }
    }
}