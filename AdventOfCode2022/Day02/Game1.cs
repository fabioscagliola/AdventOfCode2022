namespace com.fabioscagliola.AdventOfCode2022.Day02
{
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
}
