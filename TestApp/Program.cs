using TestApp.ERRORHANDELLING;
using static System.Console;

/*Product product = new ()
{
    Description = "Lorem Ipsum",
    Name = "Test",
    Price = new Price() { Currency = CurrencyType.Rupees, PriceValue = 10},
    Stock = 10
};

BoxedProduct product1 = new () { Description = "dnakll", Name = "dfsdf" , Price = new Price() {PriceValue = 10, Currency = CurrencyType.Dollars}, Stock = 12 };

Console.WriteLine(product.DisplayDetails());
Console.WriteLine();
Console.WriteLine(product1.DisplayDetails());*/
AppDomain currentAppDomain = AppDomain.CurrentDomain;
currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

WriteLine("Enter first number");
int number1 = int.Parse(ReadLine()!);

WriteLine("Enter second number");
int number2 = int.Parse(ReadLine()!);

WriteLine("Enter operation");
string operation = ReadLine()!.ToUpperInvariant();

try
{
    var calculator = new Calculator();
    int result = calculator.Calculate(number1, number2, operation);
    DisplayResult(result);
}
catch(ArgumentNullException anex)
{
    WriteLine($"Operation not provided : {anex}");
}
catch(ArgumentOutOfRangeException aoorex)
{
    WriteLine($"Operation is not supported : {aoorex}");
}
catch (Exception ex)
{
    WriteLine($"Sorry, something went wrong. {ex}");
}

WriteLine("\nPress enter to exit.");
ReadLine();


static void DisplayResult(int result) => WriteLine($"Result is: {result}");
static void HandleException(object sender, UnhandledExceptionEventArgs e)
{
    WriteLine($"Sorry there is problem and therefore program is closed. Details : {e.ExceptionObject}");
}