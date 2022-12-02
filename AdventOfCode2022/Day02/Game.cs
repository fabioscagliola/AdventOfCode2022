namespace com.fabioscagliola.AdventOfCode2022.Day02
{
    enum Shape
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3,
    }

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

    class Game1 : Game
    {
        public Game1(string s1, string s2)
        {
            SetShape1(s1);

            switch (s2)
            {
                case "X":
                    Shape2 = Shape.Rock;
                    break;
                case "Y":
                    Shape2 = Shape.Paper;
                    break;
                case "Z":
                    Shape2 = Shape.Scissors;
                    break;
            }
        }
    }

    class Game2 : Game
    {
        public Game2(string s1, string s2)
        {
            SetShape1(s1);

            switch (s2)
            {
                case "X":
                    switch (Shape1)
                    {
                        case Shape.Rock:
                            Shape2 = Shape.Scissors;
                            break;
                        case Shape.Paper:
                            Shape2 = Shape.Rock;
                            break;
                        case Shape.Scissors:
                            Shape2 = Shape.Paper;
                            break;
                    }
                    break;
                case "Y":
                    Shape2 = Shape1;
                    break;
                case "Z":
                    switch (Shape1)
                    {
                        case Shape.Rock:
                            Shape2 = Shape.Paper;
                            break;
                        case Shape.Paper:
                            Shape2 = Shape.Scissors;
                            break;
                        case Shape.Scissors:
                            Shape2 = Shape.Rock;
                            break;
                    }
                    break;
            }
        }
    }
}
