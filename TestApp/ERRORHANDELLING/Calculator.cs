namespace TestApp.ERRORHANDELLING;

public class Calculator
{
    public int Calculate(int number1, int number2, string operation)
    {
        ArgumentNullException.ThrowIfNull(operation);
        //string nonNullOperetion = operation ?? throw new ArgumentNullException(nameof(operation));
        if (operation == "/")
        {
            try
            {
                return Divide(number1, number2);
            }
            catch(DivideByZeroException ex)
            {
                throw new ArithmeticException("Invalid Operation",ex);
            }
            
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(operation));
            //Console.WriteLine("Unknown operation.");
            //return 0;
        }
    }

    private int Divide(int number, int divisor) => number / divisor;
}

