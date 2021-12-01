using System.Linq;

namespace Day1
{
    class CalculatePartOne : ICalculate
    {
        public int Calculate(int[] arr)
        {
            return arr.TakeWhile((t, i) => i <= arr.Length - 2).Where((t, i) => t < arr[i + 1]).Count();
        }
    }
}
