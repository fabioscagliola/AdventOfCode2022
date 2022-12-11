namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public class Position
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsNextTo(Position position)
        {
            return Math.Abs(position.X - X) < 2 && Math.Abs(position.Y - Y) < 2;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
