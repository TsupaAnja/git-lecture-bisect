using SurpoLab5;

class Program
{

    static void Main()
    {
        CurrencyConverter converter = new CurrencyConverter();

        converter.AddToFavorites("USD");
        converter.AddToFavorites("EUR");

        var favorites = converter.GetFavorites();
        Console.WriteLine("Favorite currencies:");
        foreach (var fav in favorites)
        {
            Console.WriteLine(fav);
        }
    }
}