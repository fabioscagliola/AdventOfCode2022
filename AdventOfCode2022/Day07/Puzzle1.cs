namespace com.fabioscagliola.AdventOfCode2022.Day07
{
    public class Puzzle1 : Puzzle, ISolvable
    {
        public object Solve(string input)
        {
            FileSystem fileSystem = new(input);

            List<Folder> folderList = TraverseTree(fileSystem.Root, (Folder folder) =>
            {
                return folder.Size < 100000;
            });

            return folderList.Sum(folder => folder.Size);
        }
    }
}
