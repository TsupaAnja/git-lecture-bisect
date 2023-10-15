using SurpoLab5;

class Program
{

    static void Main()
    {
        CurrencyConverter converter = new CurrencyConverter();

        try
        {
            var ConvertedAmount = converter.Convert(100, 0.005M);
            Console.WriteLine(ConvertedAmount);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        // decimal convertedAmount = conventer.Convert(100, 0.85M);
        // Console.WriteLine(convertedAmount.ToString());

    }
}