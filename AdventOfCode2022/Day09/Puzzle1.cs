namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public class Puzzle1 : Puzzle, ISolvable
    {
        protected override int RopeLenght { get { return 2; } }

        public object Solve(string input)
        {
            return NewMethod(input);
        }
    }
}
