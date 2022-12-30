namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public class Puzzle2 : Puzzle, ISolvable
    {
        public object Solve(string input)
        {
            return CountPositions(input, 10);
        }
    }
}
