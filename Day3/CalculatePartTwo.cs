using System;
using System.Collections;
using System.Linq;

namespace Day3
{
    internal class CalculatePartTwo : ICalculate
    {
        public int Calculate(BitArray[] arr)
        {
            BitArray oxygen = GetNumber(arr, 0, true);
            BitArray co2 = GetNumber(arr, 0, false);

            return ConvertToInt(oxygen) * ConvertToInt(co2);
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


        private BitArray GetNumber(BitArray[] arr, int position, bool valueToCheck)
        {
            int countWithTrue = arr.Count(p => p.Get(position) == true);
            int countWithFalse = arr.Count(p => p.Get(position) == false);

            var arrToSearch = countWithTrue >= countWithFalse ? arr.Where(p => p.Get(position) == valueToCheck).ToArray() : arr.Where(p => p.Get(position) == !valueToCheck).ToArray();

            if (arrToSearch.Length == 1)
                return arrToSearch[0];

            position++;
            return GetNumber(arrToSearch, position, valueToCheck);
        }
    }
}