using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurpoLab5
{
    internal class CurrencyConventer
    {
        public decimal Convert(decimal amount, decimal convertionRate)
        {
            ValidateRate(convertionRate);
            return amount * convertionRate;
        }

        private void ValidateRate(decimal rate)
        {
            // Здесь нет реальной проверки, прото заглушка для возможных будущих проверок
        }
    }
}
