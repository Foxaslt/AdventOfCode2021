using System.Collections.Generic;

namespace Day2
{
    internal interface ICalculate
    {
        int Calculate(KeyValuePair<Command, int>[] arr);
    }
}