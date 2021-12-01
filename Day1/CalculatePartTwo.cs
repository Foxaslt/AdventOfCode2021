using System.Linq;

namespace Day1
{
    class CalculatePartTwo : ICalculate
    {
        public int Calculate(int[] arr)
        {
            return arr.TakeWhile((t, i) => i <= arr.Length - 3).Where((t, i) => arr.Skip(i + 1).Take(3).Sum() > arr.Skip(i).Take(3).Sum()).Count();
        }
    }
}
