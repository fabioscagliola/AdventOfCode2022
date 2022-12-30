namespace com.fabioscagliola.AdventOfCode2022.Day07
{
    public class Folder
    {
        public string Name { get; protected set; }

        public Folder? Parent { get; protected set; }

        public List<File> FileList { get; protected set; }

        public List<Folder> FolderList { get; protected set; }

        public Folder(string name, Folder? parent)
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
                return DoSize(this);
            }
        }

        static int DoSize(Folder root)
        {
            int size = 0;

            foreach (File file in root.FileList)
                size += file.Size;

            foreach (Folder folder in root.FolderList)
                size += DoSize(folder);

            return size;
        }

        public override string ToString()
        {
            return $"{Name}, {Size}";
        }
    }
}
