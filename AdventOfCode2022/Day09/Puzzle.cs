using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public abstract class Puzzle
    {
        protected static int CountPositions(string input, int RopeLenght)
        {
            Rope rope = new(RopeLenght);

            Regex regex = new("^([RLUD])\\s(\\d+)", RegexOptions.Multiline);

            MatchCollection matchCollection = regex.Matches(input);

            for (int i = 0; i < matchCollection.Count; i++)
            {
                Match match = matchCollection[i];
                Motion motion = (Motion)Enum.Parse(typeof(Motion), match.Groups[1].Value);
                int distance = int.Parse(match.Groups[2].Value);
                rope.Head.Move(motion, distance);
            }

            return rope.KnotList[^1].PositionList.Count;
        }
    }
}
