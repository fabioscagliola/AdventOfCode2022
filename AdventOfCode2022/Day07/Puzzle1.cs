using System.Text.RegularExpressions;

namespace com.fabioscagliola.AdventOfCode2022.Day07
{
    public class Puzzle1 : ISolvable
    {
        public object Solve(string input)
        {
            Folder root = new("/", null);

            Folder cd = null;

            Regex regex = new("^(?>\\$\\s(?>(cd)\\s(\\/|\\.\\.|[a-z]+)|(ls)))|(?>(\\d+)\\s([a-z]+\\.*[a-z]*))|dir\\s([a-z]+)", RegexOptions.Multiline);

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                if (match.Value.StartsWith("$"))
                {
                    switch (match.Groups[1].Value)
                    {
                        case "cd":
                            switch (match.Groups[2].Value)
                            {
                                case "/":
                                    cd = root;
                                    break;
                                case "..":
                                    cd = cd.Parent;
                                    break;
                                default:
                                    cd = cd.FolderList.Find(folder => folder.Name == match.Groups[2].Value);
                                    break;
                            }
                            break;
                        case "ls":
                            // Do nothing 
                            break;
                    }
                }
                else
                {
                    if (match.Value.StartsWith("dir"))
                    {
                        cd.FolderList.Add(new Folder(match.Groups[6].Value, cd));
                    }
                    else
                    {
                        cd.FileList.Add(new File(match.Groups[5].Value, cd, int.Parse(match.Groups[4].Value)));
                    }
                }
            }

            List<Folder> folderList = FindLargeFolders(root);

            return folderList.Sum(folder => folder.Size);
        }

        List<Folder> FindLargeFolders(Folder root)
        {
            List<Folder> folderList = new();

            foreach (Folder folder in root.FolderList)
            {
                if (folder.Size < 100000)
                    folderList.Add(folder);

                folderList.AddRange(FindLargeFolders(folder));
            }

            return folderList;
        }
    }
}
