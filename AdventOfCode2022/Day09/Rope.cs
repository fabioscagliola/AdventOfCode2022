using System.Text;

namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public class Rope
    {
        public List<Knot> KnotList { get; protected set; }

        public Knot Head { get { return KnotList[0]; } }

        public Rope(int length)
        {
            KnotList = new();

            for (int i = 0; i < length; i++)
                KnotList.Add(new(new(0, 0)));

            Head.KnotMoved += HandleHeadKnotMoved;
        }

        void HandleHeadKnotMoved(KnotMovedArgs args)
        {
            Knot prevKnot = Head;

            Motion motion = args.Motion;

            for (int i = 1; i < KnotList.Count; i++)
            {
                Knot knot = KnotList[i];

                if (!prevKnot.Position.IsNextTo(knot.Position))
                {
                    int x = prevKnot.Position.X - knot.Position.X;
                    int y = prevKnot.Position.Y - knot.Position.Y;

                    if (x > 0 && y == 0)
                        motion = Motion.R;
                    else if (x < 0 && y == 0)
                        motion = Motion.L;
                    else if (x == 0 && y > 0)
                        motion = Motion.U;
                    else if (x == 0 && y < 0)
                        motion = Motion.D;
                    else if (x > 0 && y > 0)
                        motion = Motion.RU;
                    else if (x > 0 && y < 0)
                        motion = Motion.RD;
                    else if (x < 0 && y > 0)
                        motion = Motion.LU;
                    else if (x < 0 && y < 0)
                        motion = Motion.LD;

                    knot.Move(motion, 1);
                }

                prevKnot = knot;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            foreach (Knot knot in KnotList)
                stringBuilder.Append($"{knot}; ");
            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            return stringBuilder.ToString();
        }
    }
}
