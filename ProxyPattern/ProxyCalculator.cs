namespace ProxyPattern
{
    public class ProxyCalculator : ICalculator
    {
        private readonly ICalculator _realCalculator;
        public ProxyCalculator(ICalculator calculator)
        {
            _realCalculator = calculator;
        }

        public void Add(double a, double b)
        {
            _realCalculator.Add(a, b);
        }

        public void Multiply(double a, double b)
        {
            _realCalculator.Multiply(a, b);
        }

        public void Subtract(double a, double b)
        {
            _realCalculator.Subtract(a, b);
        }
    }
}
