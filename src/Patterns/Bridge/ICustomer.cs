namespace Patterns.Bridge
{
    public abstract class ICustomer
    {
        protected IValueHandler pc;

        public void setStrategy(IValueHandler pc) => this.pc = pc;
        public abstract decimal getTotal(decimal value);
        public abstract decimal getOrginalValue(decimal value);
    }
}
