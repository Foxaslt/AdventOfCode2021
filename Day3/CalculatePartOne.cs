using System;
using System.Collections;
using System.Linq;

namespace Day3
{
    internal class CalculatePartOne : ICalculate
    {
        public int Calculate(BitArray[] arr)
        {
            BitArray gama = new BitArray(12);
            for (int i = 0; i < 12; i++)
            {
                var isTrue = arr.Count(s => s[i]);
                var isFalse = arr.Count(s => !s[i]);
                if (isTrue > isFalse)
                    gama[i] = true;
                else
                    gama[i] = false;
            }

            BitArray epsilon = new BitArray(gama);
            epsilon.Not();
            int gamaInt = ConvertToInt(gama);
            int epsilonInt = ConvertToInt(epsilon);

            return gamaInt * epsilonInt;
        }

        private int ConvertToInt(BitArray binary)
        {
            var len = Math.Min(64, binary.Count);
            ulong n = 0;
            for (int i = 0; i < len; i++)
            {
                if (binary.Get(i))
                    n |= 1UL << len - i - 1;
            }
            return (int)n;
        }
    }
}