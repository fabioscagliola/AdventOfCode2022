namespace com.fabioscagliola.AdventOfCode2022.Day01
{
    class Puzzle2 : Puzzle, ISolvable
    {
        public int Solve(string input)
        {
            int result = 0;
            List<int> list = DoList(input);
            list.Sort((a, b) => b.CompareTo(a));
            for (int i = 0; i < 3; i++)
                result += list[i];
            return result;
        }
    }
}
