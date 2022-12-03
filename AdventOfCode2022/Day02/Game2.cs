namespace com.fabioscagliola.AdventOfCode2022.Day02
{
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
