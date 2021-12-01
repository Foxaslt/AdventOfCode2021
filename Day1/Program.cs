using System;
using System.IO;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawData = File.ReadAllLines("RawData.txt");

            var arr = rawData.Select(int.Parse).ToArray();

            ICalculate calcOne = new CalculatePartOne();
            var increase = calcOne.Calculate(arr);

            Console.WriteLine($"Increased {increase} times");

            ICalculate calc = new CalculatePartTwo();
            increase = calc.Calculate(arr);

            Console.WriteLine($"Increased {increase} times");
        }
    }
}
