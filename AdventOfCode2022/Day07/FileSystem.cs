using System.Text.RegularExpressions;

#nullable disable

namespace com.fabioscagliola.AdventOfCode2022.Day07
{
    public class FileSystem
    {
        public static int Size { get { return 70000000; } }

        public Folder Root { get; protected set; }

        public FileSystem(string input)
        {
            Root = new("/", null);

            Folder cd = null;

            Regex regex = new("^(?>\\$\\s(?>(cd)\\s(\\/|\\.\\.|[a-z]+)|(ls)))|(?>(\\d+)\\s([a-z]+\\.*[a-z]*))|dir\\s([a-z]+)", RegexOptions.Multiline);

            MatchCollection matchCollection = regex.Matches(input);

            for (int i = 0; i < matchCollection.Count; i++)
            {
                Match match = matchCollection[i];

                if (match.Value.StartsWith("$"))
                {
                    switch (match.Groups[1].Value)
                    {
                        case "cd":
                            switch (match.Groups[2].Value)
                            {
                                case "/":
                                    cd = Root;
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
        }

        public int AvailableSpace { get { return Size - Root.Size; } }
    }
}
