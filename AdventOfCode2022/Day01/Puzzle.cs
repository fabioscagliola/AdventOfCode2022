using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day01
{
    abstract class Puzzle
    {
        protected static List<int> DoList(string input)
        {
            List<int> list = new();

            Regex regex = new("^\\d*", RegexOptions.Multiline);

            MatchCollection matchCollection = regex.Matches(input);

            int calories = 0;

            foreach (Match match in matchCollection)
            {
                if (!string.IsNullOrWhiteSpace(match.Value))
                {
                    calories += int.Parse(match.Value);
                }
                else
                {
                    list.Add(calories);
                    calories = 0;
                }
            }

            return list;
        }
    }
}
