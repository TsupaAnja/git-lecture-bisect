using SurpoLab5;

class Program
{

    static void Main()
    {
        CurrencyConventer conventer = new CurrencyConventer();
        decimal convertedAmount = conventer.Convert(100, 0.85M);
        Console.WriteLine(convertedAmount.ToString());
    }
}