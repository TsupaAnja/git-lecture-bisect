using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurpoLab5
{
    /// <summary>
    /// Базовый класс для конвертации валют
    /// </summary>
    internal class CurrencyConverter
    {
        private Dictionary<DateTime, decimal> historicalRates = new Dictionary<DateTime, decimal>
        {
            {new DateTime(2022, 1,1), 0.85M},
            {new DateTime(2022, 2,1), 0.86M},
            {new DateTime(2022, 3,1), 0.87M}
        };

        private List<string> favorites = new List<string>();
        
        public decimal Convert(decimal amount, decimal convertionRate)
        {
            ValidateRate(convertionRate);
            return PerformConversion(amount, convertionRate);
        }

        private decimal PerformConversion(decimal amount, decimal convertionRate)
        {
            return amount * convertionRate;
        }

        private void ValidateRate(decimal rate)
        {
            if (rate < 0.00001M)
                throw new ArgumentException("Предлагаемый коэффицент кажется слишком маленьким, перепроверьте плиз");
        }

        public decimal GetHistoricalRate(DateTime date)
        {
            return historicalRates.TryGetValue(date, out decimal rate) ? 
                rate : 
                throw new ArgumentException("Заданное историческое значение не было найдено в БД");
        }

        public void AddToFavorites(string currencyCode)
        {
            if (!favorites.Contains(currencyCode))
            {
                favorites.Add(currencyCode);
            }
        }

        public void RemoveFromFavorites(string currencyCode)
        {
            if (!favorites.Contains(currencyCode))
            {
                favorites.Remove(currencyCode);
            }
        }

        public IEnumerable<string> GetFavorites()
        {
            return favorites.AsReadOnly();
        }

        //

    }
}
