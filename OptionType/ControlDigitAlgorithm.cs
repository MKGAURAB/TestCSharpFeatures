namespace DigitExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ControlDigitAlgorithm
    {
        private Func<long, IEnumerable<int>> GetDigits { get; }
        private IEnumerable<int> MultiplyingFactors { get; }
        private int Modulo;

        public ControlDigitAlgorithm(Func<long, IEnumerable<int>> getDigits, IEnumerable<int> multiplyingFactors, int modulo)
        {
            GetDigits = getDigits;
            MultiplyingFactors = multiplyingFactors;
            Modulo = modulo;
        }

        public long GetControlledSum(long num)
        {
            return this.GetDigits(num)
                .Zip(MultiplyingFactors, (a, b) => a * b)
                .Sum() % Modulo;
        }
    }
}
