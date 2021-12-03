using System.Collections.Generic;

namespace Day2
{
    internal class CalculatePartOne : ICalculate
    {
        public int Calculate(KeyValuePair<Command, int>[] arr)
        {
            int depth = 0;
            int forward = 0;

            foreach (var t in arr)
            {
                CalcCoordinates(t, ref forward, ref depth);
            }

            return depth * forward;
        }

        private static void CalcCoordinates(KeyValuePair<Command, int> t, ref int forward, ref int depth)
        {
            switch (t.Key)
            {
                case Command.forward:
                    forward += t.Value;
                    break;
                case Command.up:
                    depth -= t.Value;
                    break;
                case Command.down:
                    depth += t.Value;
                    break;
            }
        }
    }
}