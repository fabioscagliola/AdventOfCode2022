namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public delegate void KnotMovedEventHandler(KnotMovedArgs eventArgs);

    public class Knot
    {
        public event KnotMovedEventHandler? KnotMoved;

        public Position Position { get; protected set; }

        public List<Position> PositionList { get; protected set; }

        public Knot(Position position)
        {
            Position = position;
            PositionList = new() { new(0, 0) };
        }

        public void Move(Motion motion, int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                switch (motion)
                {
                    case Motion.R:
                        Position.X++;
                        break;
                    case Motion.L:
                        Position.X--;
                        break;
                    case Motion.U:
                        Position.Y++;
                        break;
                    case Motion.D:
                        Position.Y--;
                        break;
                    case Motion.RU:
                        Position.X++;
                        Position.Y++;
                        break;
                    case Motion.RD:
                        Position.X++;
                        Position.Y--;
                        break;
                    case Motion.LU:
                        Position.X--;
                        Position.Y++;
                        break;
                    case Motion.LD:
                        Position.X--;
                        Position.Y--;
                        break;
                }

                if (PositionList.Find(position => position.X == Position.X && position.Y == Position.Y) == null)
                    PositionList.Add(new(Position.X, Position.Y));

                KnotMoved?.Invoke(new(motion));
            }
        }
    }
}
