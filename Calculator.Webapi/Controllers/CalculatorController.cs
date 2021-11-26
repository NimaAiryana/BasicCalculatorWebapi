using Calculator.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService calculatorService;

        public CalculatorController(ICalculatorService calculatorService) => this.calculatorService = calculatorService;

        [HttpGet("add")]
        public async Task<decimal> AddAsync(decimal number1, decimal number2)
            => await Task.Run(() =>
            {
                return calculatorService.Add(number1, number2);
            });

        [HttpGet("minus")]
        public async Task<decimal> MinusAsync(decimal number1, decimal number2)
            => await Task.Run(() =>
            {
                return calculatorService.Minus(number1, number2);
            });

        [HttpGet("multiplication")]
        public async Task<decimal> MultiplicationAsync(decimal number1, decimal number2)
            => await Task.Run(() =>
            {
                return calculatorService.Multiplication(number1, number2);
            });

        [HttpGet("divide")]
        public async Task<decimal> DivideAsync(decimal number1, decimal number2)
            => await Task.Run(() =>
            {
                return calculatorService.Divide(number1, number2);
            });
    }
}
