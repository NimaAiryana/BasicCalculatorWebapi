namespace Calculator.Core.Contracts.Implements
{
    public class CalculatorService : ICalculatorService
    {
        public decimal Add(decimal number1, decimal number2) => number1 + number2;

        public decimal Divide(decimal number1, decimal number2)
        {
            if (number2 == 0) throw new System.Exception($"The {nameof(number2)} should not be Zero!");

            return number1 / number2;
        }

        public decimal Minus(decimal number1, decimal number2) => number1 - number2;

        public decimal Multiplication(decimal number1, decimal number2) => number1 * number2;
    }
}
