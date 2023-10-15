using SurpoLab5;

class Program
{

    static void Main()
    {
        CurrencyConventer conventer = new CurrencyConventer();
        // decimal convertedAmount = conventer.Convert(100, 0.85M);
        // Console.WriteLine(convertedAmount.ToString());

        DateTime historicalDate = new DateTime(2022, 2, 1);
        decimal historicalRate = conventer.GetHistoricalRate(historicalDate);
        decimal conventerAmount = conventer.Convert(100, historicalRate);
        Console.WriteLine(conventerAmount.ToString());

    }
}