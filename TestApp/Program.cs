using TestApp;

Product product = new ()
{
    Description = "Lorem Ipsum",
    Name = "Test",
    Price = new Price() { Currency = CurrencyType.Rupees, PriceValue = 10},
    Stock = 10
};

BoxedProduct product1 = new () { Description = "dnakll", Name = "dfsdf" , Price = new Price() {PriceValue = 10, Currency = CurrencyType.Dollars}, Stock = 12 };

Console.WriteLine(product.DisplayDetails());
Console.WriteLine();
Console.WriteLine(product1.DisplayDetails());