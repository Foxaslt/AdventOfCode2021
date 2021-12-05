using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawData = File.ReadAllLines("RawData.txt");

            var numbers = rawData[0].Split(',').Select(int.Parse).ToArray();

            List<IBoard> boards = new List<IBoard>();
            var startingRow = 2;
            var i = 0;
            while (startingRow < rawData.Length)
            {
                var rows = rawData.Skip(startingRow).Take(5);

                IBoard board = new Board(rows);
                boards.Add(board);

                startingRow += 6;
                i++;
            }

            foreach (var number in numbers)
            {
                for (var index = 0; index < boards.Count; index++)
                {
                    var board = boards[index];
                    board.Mark(number);
                    if (board.IsWinner)
                    {
                        int sum = board.GetSum();
                        int result = sum * number;
                        Console.WriteLine($"Number called {number}, sum {sum}, result {result}.");
                        boards.Remove(board);
                        index--;
                    }
                }
            }
        }
    }
}
