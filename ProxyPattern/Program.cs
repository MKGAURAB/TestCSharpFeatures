using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator realCalculator = new Calculator();
            ICalculator proxyCalc = new ProxyCalculator(realCalculator);

            proxyCalc.Add(1, 2);
            proxyCalc.Subtract(1000, -10000);
            proxyCalc.Multiply(1999, -2);

            Console.WriteLine("Hello World!");
        }
    }
}
