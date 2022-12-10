namespace com.fabioscagliola.AdventOfCode2022.Day07
{
    public class File
    {
        public string Name { get; protected set; }

        public Folder Parent { get; protected set; }

        public int Size { get; protected set; }

        public File(string name, Folder parent, int size)
        {
            Name = name;
            Parent = parent;
            Size = size;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
