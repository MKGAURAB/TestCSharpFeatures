using System;
namespace ProxyPattern
{
    public class ProxyCalculator : ICalculator
    {
        protected ICalculator realCalculator;
        public ProxyCalculator(ICalculator calculator)
        {
            realCalculator = calculator;
        }

        public void Add(double a, double b)
        {
            realCalculator.Add(a, b);
        }

        public void Multiply(double a, double b)
        {
            realCalculator.Multiply(a, b);
        }

        public void Subtract(double a, double b)
        {
            realCalculator.Subtract(a, b);
        }
    }
}
