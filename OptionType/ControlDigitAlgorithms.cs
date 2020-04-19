namespace FuncWithStrategy
{
    using System.Collections.Generic;
    using DigitExtraction;

    static class ControlDigitAlgorithms
    {
        public static long ForLowest(long num) =>
            new ControlDigitAlgorithm(x => x.DigitsFromLowest(), MultiplyingFactors, 1000).GetControlledSum(num);

        private static IEnumerable<int> MultiplyingFactors
        {
            get
            {
                int factor = 3;
                while (true)
                {
                    yield return factor;
                    factor = 4 - factor;
                }
            }
        }
    }
}
