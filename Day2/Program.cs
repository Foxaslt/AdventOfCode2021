using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawData = File.ReadAllLines("RawData.txt");

            var arr = rawData.Select(r =>
            {
                var row = r.Split(' ');
                return new KeyValuePair<Command,int>(Enum.Parse<Command>(row[0]), int.Parse(row[1]));
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
