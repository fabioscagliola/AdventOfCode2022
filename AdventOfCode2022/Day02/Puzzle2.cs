namespace com.fabioscagliola.AdventOfCode2022.Day02
{
    class Puzzle2 : Puzzle, ISolvable
    {
        public int Solve(string input)
        {
            List<Game> list = DoList(input, (string s1, string s2) => { return new Game2(s1, s2); });
            return list.Sum(game => game.Score);
        }
    }
}
