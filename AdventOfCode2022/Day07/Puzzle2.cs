namespace com.fabioscagliola.AdventOfCode2022.Day07
{
    public class Puzzle2 : Puzzle, ISolvable
    {
        public object Solve(string input)
        {
            FileSystem fileSystem = new(input);

            List<Folder> folderList = TraverseTree(fileSystem.Root, (Folder folder) =>
            {
                return fileSystem.AvailableSpace + folder.Size > 30000000;
            });

            folderList.Sort((a, b) => a.Size.CompareTo(b.Size));

            return folderList[0].Size;
        }
    }
}
