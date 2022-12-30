namespace com.fabioscagliola.AdventOfCode2022.Day07
{
    public class Puzzle
    {
        protected List<Folder> TraverseTree(Folder cd, Func<Folder, bool> func)
        {
            List<Folder> folderList = new();

            foreach (Folder folder in cd.FolderList)
            {
                if (func(folder))
                    folderList.Add(folder);

                folderList.AddRange(TraverseTree(folder, func));
            }

            return folderList;
        }
    }
}
