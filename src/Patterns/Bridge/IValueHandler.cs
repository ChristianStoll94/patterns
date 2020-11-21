namespace Patterns.Bridge
{
    public interface IValueHandler
    {
        decimal getValue(decimal value);
        decimal getOrginalValue(decimal value);
    }
}
