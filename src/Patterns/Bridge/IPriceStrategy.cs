namespace Patterns.Bridge
{
    public interface IPriceStrategy
    {
        decimal GetValue(decimal value);
        decimal GetOriginalValue(decimal value);
    }
}
