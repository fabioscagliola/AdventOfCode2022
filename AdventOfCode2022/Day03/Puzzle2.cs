using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day03
{
    class Puzzle2 : Puzzle, ISolvable
    {
        public int Solve(string input)
        {
            MatchCollection matchCollection = GetMatchCollection(input);

            List<int> list = new();

            for (int i = 0; i < matchCollection.Count; i += 3)
            {
                string s1 = matchCollection[i].Value;
                string s2 = matchCollection[i + 1].Value;
                string s3 = matchCollection[i + 2].Value;

                List<char> duplicates = FindDuplicates(s1, s2, s3);

                foreach (char c in duplicates)
                    list.Add(GetPriority(c));
            }

            return list.Sum();
        }
    }
}
