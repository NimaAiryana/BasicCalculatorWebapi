namespace Calculator.Core.Contracts
{
    public interface ICalculatorService
    {
        decimal Add(decimal number1, decimal number2);
        decimal Minus(decimal number1, decimal number2);
        decimal Multiplication(decimal number1, decimal number2);
        decimal Divide(decimal number1, decimal number2);
    }
}
