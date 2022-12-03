namespace com.fabioscagliola.AdventOfCode2022.Day02
{
    abstract class Game
    {
        public Shape Shape1 { get; protected set; }

        public Shape Shape2 { get; protected set; }

        public int Score
        {
            get
            {
                if ((Shape2 == Shape.Rock && Shape1 == Shape.Scissors) || (Shape2 == Shape.Scissors && Shape1 == Shape.Paper) || (Shape2 == Shape.Paper && Shape1 == Shape.Rock))
                    return (int)Shape2 + 6;
                else if (Shape2 == Shape1)
                    return (int)Shape2 + 3;
                else
                    return (int)Shape2 + 0;
            }
        }

        protected void SetShape1(string s1)
        {
            switch (s1)
            {
                case "A":
                    Shape1 = Shape.Rock;
                    break;
                case "B":
                    Shape1 = Shape.Paper;
                    break;
                case "C":
                    Shape1 = Shape.Scissors;
                    break;
            }
        }
    }
}
