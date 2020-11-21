using System;

namespace Patterns.Bridge
{
    public class NormalSale : ICustomer
    {
        public override decimal getTotal(decimal value)
        {
            return pc.getValue(value);
        }

        public override decimal getOrginalValue(decimal value)
        {
            return pc.getOrginalValue(value);
        }
        
    }
}
