using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawData = File.ReadAllLines("RawData.txt");
            string pattern = @"(\w*,\w*)\s->\s(\w*,\w*)";

            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);

            var groups = rawData.Select(data => r.Match(data).Groups);

            var maxX = 0;
            var maxY = 0;
        }
    }
}
