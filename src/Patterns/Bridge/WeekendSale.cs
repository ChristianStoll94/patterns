using System;

namespace Patterns.Bridge
{
    public class WeekendSale : ICustomer
    {
        public override decimal getTotal(decimal value)
        {
            return pc.getValue(pc.getValue(value));
        }

        public override decimal getOrginalValue(decimal value)
        {
            return pc.getOrginalValue(value);
        }
    }
}
