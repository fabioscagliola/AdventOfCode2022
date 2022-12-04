namespace com.fabioscagliola.AdventOfCode2022.Day04
{
    class Puzzle2 : Puzzle, ISolvable
    {
        public int Solve(string input)
        {
            return Solve(input, (Interval interval1, Interval interval2) =>
            {
                return interval1.Overlaps(interval2) || interval2.Overlaps(interval1);
            });
        }
    }
}
