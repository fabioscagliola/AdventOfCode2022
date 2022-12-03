using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day03
{
    abstract class Puzzle
    {
        protected static MatchCollection GetMatchCollection(string input)
        {
            Regex regex = new("^\\w+", RegexOptions.Multiline);
            return regex.Matches(input);
        }

        protected static List<char> FindDuplicates(string s1, string s2)
        {
            List<char> list = new();

            foreach (char c1 in s1)
                foreach (char c2 in s2)
                    if (c1 == c2)
                        if (!list.Contains(c1))
                            list.Add(c1);

            return list;
        }

        protected static List<char> FindDuplicates(string s1, string s2, string s3)
        {
            List<char> list = new();

            foreach (char c1 in s1)
                foreach (char c2 in s2)
                    foreach (char c3 in s3)
                        if (c1 == c2 && c1 == c3)
                            if (!list.Contains(c1))
                                list.Add(c1);

            return list;
        }

        protected static int GetPriority(char c)
        {
            return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(c) + 1;
        }
    }
}
