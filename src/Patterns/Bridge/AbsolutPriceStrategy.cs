using System;

namespace Patterns.Bridge
{
    public class AbsolutPriceStrategy : IValueHandler
    {
        private readonly decimal _absoluteDiscount;
        public AbsolutPriceStrategy(decimal absoluteDiscount)
        {
            _absoluteDiscount = absoluteDiscount;
        }
        public decimal getValue(decimal value)
        {
            return value - _absoluteDiscount;
        }

        public decimal getOrginalValue(decimal value)
        {
            return value;
        }
    }
}
