using SurpoLab5;

class Program
{

    static void Main()
    {
        CurrencyConverter converter = new CurrencyConverter();
        // decimal convertedAmount = conventer.Convert(100, 0.85M);
        // Console.WriteLine(convertedAmount.ToString());

        DateTime historicalDate = new DateTime(2022, 2, 1);
        decimal historicalRate = converter.GetHistoricalRate(historicalDate);
        decimal conventerAmount = converter.Convert(100, historicalRate);
        Console.WriteLine(conventerAmount.ToString());

    }
}