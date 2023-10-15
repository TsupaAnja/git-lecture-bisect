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
            return amount * convertionRate;
        }
    }
}
