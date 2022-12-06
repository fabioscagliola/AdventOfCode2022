namespace com.fabioscagliola.AdventOfCode2022.Day06
{
    public abstract class Puzzle
    {
        protected abstract int MarkerLenght { get; }

        static bool ContainsDuplicates(string s)
        {
            for (int i = 0; i < s.Length; i++)
                for (int j = i + 1; j < s.Length; j++)
                    if (s[i] == s[j])
                        return true;
            return false;
        }

        public object Solve(string input)
        {
            for (int i = 0; i < input.Length; i++)
                if (!ContainsDuplicates(input.Substring(i, MarkerLenght)))
                    return i + MarkerLenght;
            return -1;
        }
    }
}
