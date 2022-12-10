namespace com.fabioscagliola.AdventOfCode2022.Day07
{
    public class Folder
    {
        public string Name { get; protected set; }

        public Folder Parent { get; protected set; }

        public List<File> FileList { get; protected set; }

        public List<Folder> FolderList { get; protected set; }

        public Folder(string name, Folder parent)
        {
            Name = name;
            Parent = parent;
            FileList = new();
            FolderList = new();
        }

        public int Size
        {
            get
            {
                int size = 0;

                foreach (File file in FileList)
                    size += file.Size;

                foreach (Folder folder in FolderList)
                    foreach (File file in folder.FileList)
                        size += file.Size;

                return size;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
