using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day02
{
    abstract class Puzzle
    {
        protected static List<Game> DoList(string input, Func<string, string, Game> func)
        {
            List<Game> list = new();

            Regex regex = new("^(\\w) (\\w)", RegexOptions.Multiline);

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                list.Add(func(match.Groups[1].Value, match.Groups[2].Value));
            }

            return list;
        }
    }
}
