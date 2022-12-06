using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day05
{
    public abstract class Puzzle
    {
        protected abstract void MoveCrates(List<Stack<string>> stacks, int quantity, int sourceStackIndex, int targetStackIndex);

        protected List<Stack<string>> FillStacks(string input)
        {
            List<Stack<string>> stacks = new();

            for (int i = 0; i < input.Substring(0, input.IndexOf("\r")).Length / 4 + 1; i++)
                stacks.Add(new());

            {
                Regex regex = new("(?>(?>\\[(\\w)\\]\\s)|(?>\\s{3,4}))", RegexOptions.Multiline);  // This regex may be improved 

                MatchCollection matchCollection = regex.Matches(input);

                for (int i = matchCollection.Count - 1; i > -1; i--)
                    if (!string.IsNullOrWhiteSpace(matchCollection[i].Value))
                        stacks[i % stacks.Count].Push(matchCollection[i].Groups[1].Value);
            }

            {
                Regex regex = new("(?>move (\\d+) from (\\d+) to (\\d+))", RegexOptions.Multiline);

                MatchCollection matchCollection = regex.Matches(input);

                for (int i = 0; i < matchCollection.Count; i++)
                {
                    Match match = matchCollection[i];

                    int quantity = int.Parse(match.Groups[1].Value);
                    int sourceStackIndex = int.Parse(match.Groups[2].Value) - 1;
                    int targetStackIndex = int.Parse(match.Groups[3].Value) - 1;

                    MoveCrates(stacks, quantity, sourceStackIndex, targetStackIndex);
                }
            }

            return stacks;
        }
    }
}
