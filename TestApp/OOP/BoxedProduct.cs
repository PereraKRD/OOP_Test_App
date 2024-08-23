using System.Text;

namespace TestApp.OOP;

internal class BoxedProduct : Product
{
    public new string DisplayDetails()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.AppendLine("This is a BoxedProduct");

        stringBuilder.AppendLine(base.DisplayDetails());

        return stringBuilder.ToString();
    }
}
