namespace Solid.OpenClosed.BreakingTheRule
{
    public enum CustomerType
    {
        Legal,
        AutonomousLegal,
        NonLegal,
    }

    class Customer
    {
        public CustomerType CustomerType { get; set; }

        public double GetValue()
        {
            double value;

            if (CustomerType == CustomerType.Legal) value = 1.1;
            else if (CustomerType == CustomerType.AutonomousLegal) value = 1.2;
            else value = 1.5;

            return value;
        }
    }
}
