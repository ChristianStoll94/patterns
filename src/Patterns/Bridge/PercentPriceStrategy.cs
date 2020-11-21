using System;

namespace Patterns.Bridge
{
    public class PercentPriceStrategy : IValueHandler
    {
        private readonly decimal _percentageDiscount;

        public PercentPriceStrategy(decimal percentageDiscount)
        {
            _percentageDiscount = percentageDiscount;
        }
        public decimal getValue(decimal value)
        {
            return value - (value / 100m * _percentageDiscount);
        }

        public decimal getOrginalValue(decimal value)
        {
            return value;
        }
    }
}
