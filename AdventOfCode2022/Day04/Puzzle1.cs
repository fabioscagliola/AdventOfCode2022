namespace com.fabioscagliola.AdventOfCode2022.Day04
{
    class Puzzle1 : Puzzle, ISolvable
    {
        public int Solve(string input)
        {
            return Solve(input, (Interval interval1, Interval interval2) =>
            {
                return interval1.IsSubsetOf(interval2) || interval2.IsSubsetOf(interval1);
            });
        }
    }
}
