using System.Text;

namespace TestApp.OOP;

internal class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Price Price { get; set; }
    public int Stock { get; set; } = 0;


    protected void IncreaseStock()
    {
        Stock++;
    }

    protected void DecreaseStock()
    {
        Stock--;
    }

    public virtual string DisplayDetails()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"Name : {Name} \t");
        sb.Append($"Price : {Price.PriceValue} \t");
        sb.Append($"Stock : {Stock}");

        return sb.ToString();
    }
}
