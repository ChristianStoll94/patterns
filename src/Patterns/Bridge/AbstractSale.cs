namespace Patterns.Bridge
{
    public abstract class AbstractSale
    {
        protected IPriceStrategy _priceStrategy;

        public void SetStrategy(IPriceStrategy priceStrategy) 
        {
            _priceStrategy = priceStrategy;
        }

        public abstract decimal GetTotal(decimal value);
        public abstract decimal GetOriginalValue(decimal value);
    }
}
