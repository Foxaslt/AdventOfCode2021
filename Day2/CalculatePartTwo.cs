using System.Collections.Generic;

namespace Day2
{
    internal class CalculatePartTwo : ICalculate
    {
        public int Calculate(KeyValuePair<Command, int>[] arr)
        {
            int depth = 0;
            int forward = 0;
            int aim = 0;

            foreach (var t in arr)
            {
                CalcCoordinates(t, ref forward, ref depth, ref aim);
            }

            return depth * forward;
        }

        private static void CalcCoordinates(KeyValuePair<Command, int> t, ref int forward, ref int depth, ref int aim)
        {
            switch (t.Key)
            {
                case Command.forward:
                    forward += t.Value;
                    depth += aim * t.Value;
                    break;
                case Command.up:
                    aim -= t.Value;
                    break;
                case Command.down:
                    aim += t.Value;
                    break;
            }
        }
    }
}