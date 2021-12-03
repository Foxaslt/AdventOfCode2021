using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawData = File.ReadAllLines("RawData.txt");

            var arr = rawData.Select(r =>
            {
                var b = r.Select(v => v == '1').ToArray();
                return new BitArray(b);
            }).ToArray();

            ICalculate partOne = new CalculatePartOne();
            var output = partOne.Calculate(arr);

            Console.WriteLine($"Result is {output}.");

            ICalculate partTwo = new CalculatePartTwo();
            output = partTwo.Calculate(arr);

            Console.WriteLine($"Result is {output}.");
        }
    }
}
