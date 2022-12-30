namespace com.fabioscagliola.AdventOfCode2022.Day09
{
    public class KnotMovedArgs : EventArgs
    {
        public Motion Motion { get; protected set; }

        public KnotMovedArgs(Motion motion)
        {
            Motion = motion;
        }
    }
}
