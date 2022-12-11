using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public abstract class Puzzle
    {
        protected abstract int RopeLenght { get; }

        protected int NewMethod(string input)
        {
            Rope rope = new(RopeLenght);

            Regex regex = new("^([RLUD])\\s(\\d+)", RegexOptions.Multiline);

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                Motion motion = (Motion)Enum.Parse(typeof(Motion), match.Groups[1].Value);
                int distance = int.Parse(match.Groups[2].Value);
                rope.Head.Move(motion, distance);
            }

            return rope.KnotList[^1].PositionList.Count;
        }
    }
}
