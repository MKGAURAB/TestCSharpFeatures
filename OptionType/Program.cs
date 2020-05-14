namespace OptionType
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using FuncWithStrategy;

    internal class Option<T> : IEnumerable<T>
    {
        private IEnumerable<T> Content { get; }

        private Option(IEnumerable<T> content)
        {
            Content = content;
        }

        public static Option<T> Some(T value) => new Option<T>(new [] {value});

        public static Option<T> None() => new Option<T>(new T[0]);
        public IEnumerator<T> GetEnumerator() => this.Content.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    internal static class EnumerableExtensions
    {
        public static void PerformAction<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence)
            {
                action(item);
            }
        }
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            var test = Option<string>.None();
            test.PerformAction(item => Console.WriteLine($"I am {item}"));

            test = Option<string>.Some("Gaurab");
            test.PerformAction(item => Console.WriteLine($"I am {item}"));

            var sum = ControlDigitAlgorithms.ForLowest(1234); // Using Static Factory Method
            Console.WriteLine($"Hello World! I am sum {sum}");
        }
    }
}