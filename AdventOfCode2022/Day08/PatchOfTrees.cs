namespace com.fabioscagliola.AdventOfCode2022.Day08
{
    public class PatchOfTrees : List<List<Tree>>
    {
        public PatchOfTrees(string input)
        {
            int rowIndex = 0;

            foreach (string line in input.Split("\r\n"))
            {
                Add(new List<Tree>());

                for (int colIndex = 0; colIndex < line.Length; colIndex++)
                    this[rowIndex].Add(new Tree(this, rowIndex, colIndex, int.Parse(line[colIndex].ToString())));

                rowIndex++;
            }
        }
    }
}
