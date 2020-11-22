using System;

namespace Patterns.Bridge
{
    public class AbsolutePriceStrategy : IPriceStrategy
    {
        private readonly decimal _absoluteDiscount;
        public AbsolutePriceStrategy(decimal absoluteDiscount)
        {
            _absoluteDiscount = absoluteDiscount;
        }
        public decimal GetValue(decimal value)
        {
            return value - _absoluteDiscount;
        }

        public decimal GetOriginalValue(decimal value)
        {
            return value;
        }
    }
}
