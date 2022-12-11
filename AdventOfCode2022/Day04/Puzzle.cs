using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day04
{
    abstract class Puzzle
    {
        protected static int Solve(string input, Func<Interval, Interval, bool> func)
        {
            int result = 0;

            Regex regex = new("(^\\d+)-(\\d+),(\\d+)-(\\d+)", RegexOptions.Multiline);

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                int min1 = int.Parse(match.Groups[1].Value);
                int max1 = int.Parse(match.Groups[2].Value);
                int min2 = int.Parse(match.Groups[3].Value);
                int max2 = int.Parse(match.Groups[4].Value);

                Interval interval1 = new(min1, max1);
                Interval interval2 = new(min2, max2);

                if (func(interval1, interval2))
                    result++;
            }

            return result;
        }
    }
}
