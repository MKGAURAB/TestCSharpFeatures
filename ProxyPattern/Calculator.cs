using System;
namespace ProxyPattern
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {
        }

        private void PrintValue(double result) => Console.WriteLine($"Result is: {result}");

        public void Add(double a, double b)
        {
            PrintValue(a - b);
        }

        public void Multiply(double a, double b)
        {
            PrintValue(a * b);
        }

        public void Subtract(double a, double b)
        {
            PrintValue(a-b);
        }
    }
}
