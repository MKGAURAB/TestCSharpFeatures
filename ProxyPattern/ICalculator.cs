using System;
namespace ProxyPattern
{
    public interface ICalculator
    {
        void Add(double a, double b);
        void Subtract(double a, double b);
        void Multiply(double a, double b);
    }
}
