namespace com.fabioscagliola.AdventOfCode2022.Day01
{
    class Puzzle1 : Puzzle, ISolvable
    {
        public object Solve(string input)
        {
            List<int> list = DoList(input);
            return list.Max();
        }
    }
}
