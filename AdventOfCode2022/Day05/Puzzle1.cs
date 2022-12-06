using System.Text;

namespace com.fabioscagliola.AdventOfCode2022.Day05
{
    class Puzzle1 : Puzzle, ISolvable
    {
        public object Solve(string input)
        {
            List<Stack<string>> stacks = FillStacks(input);

            StringBuilder stringBuilder = new();

            for (int i = 0; i < stacks.Count; i++)
                stringBuilder.Append(stacks[i].Peek());

            return stringBuilder.ToString();
        }

        protected override void MoveCrates(List<Stack<string>> stacks, int quantity, int sourceStackIndex, int targetStackIndex)
        {
            for (int i = 0; i < quantity; i++)
                stacks[targetStackIndex].Push(stacks[sourceStackIndex].Pop());
        }
    }
}
