namespace com.fabioscagliola.AdventOfCode2022.Day08
{
    public class Puzzle2 : ISolvable
    {
        public object Solve(string input)
        {
            int result = 0;

            PatchOfTrees patchOfTrees = new(input);

            for (int rowIndex = 0; rowIndex < patchOfTrees.Count; rowIndex++)
                for (int colIndex = 0; colIndex < patchOfTrees[rowIndex].Count; colIndex++)
                    if (patchOfTrees[rowIndex][colIndex].ScenicScore > result)
                        result = patchOfTrees[rowIndex][colIndex].ScenicScore;

            return result;
        }
    }
}
