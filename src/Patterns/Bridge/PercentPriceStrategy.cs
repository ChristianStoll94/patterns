using System;

namespace Patterns.Bridge
{
    public class PercentPriceStrategy : IPriceStrategy
    {
        private readonly decimal _percentageDiscount;

        public PercentPriceStrategy(decimal percentageDiscount)
        {
            _percentageDiscount = percentageDiscount;
        }
        public decimal GetValue(decimal value)
        {
            return value - (value / 100m * _percentageDiscount);
        }

        public decimal GetOriginalValue(decimal value)
        {
            return value;
        }
    }
}
