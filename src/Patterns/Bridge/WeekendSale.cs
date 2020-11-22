using System;

namespace Patterns.Bridge
{
    public class WeekendSale : AbstractSale
    {
        public override decimal GetTotal(decimal value)
        {
            return _priceStrategy.GetValue(_priceStrategy.GetValue(value));
        }

        public override decimal GetOriginalValue(decimal value)
        {
            return _priceStrategy.GetOriginalValue(value);
        }
    }
}
