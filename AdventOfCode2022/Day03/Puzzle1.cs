using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day03
{
    class Puzzle1 : Puzzle, ISolvable
    {
        public object Solve(string input)
        {
            MatchCollection matchCollection = GetMatchCollection(input);

            List<int> list = new();

            for (int i = 0; i < matchCollection.Count; i++)
            {
                Match match = matchCollection[i];

                string s1 = match.Value[..(match.Value.Length / 2)];
                string s2 = match.Value[(match.Value.Length / 2)..];

                List<char> duplicates = FindDuplicates(s1, s2);

                foreach (char c in duplicates)
                    list.Add(GetPriority(c));
            }

            return list.Sum();
        }
    }
}
