namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public class Puzzle2 : Puzzle, ISolvable
    {
        protected override int RopeLenght { get { return 10; } }

        public object Solve(string input)
        {
            return NewMethod(input);
        }
    }
}
