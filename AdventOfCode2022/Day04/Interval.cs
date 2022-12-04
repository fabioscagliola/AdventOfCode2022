namespace com.fabioscagliola.AdventOfCode2022.Day04
{
    class Interval
    {
        public int Min { get; protected set; }

        public int Max { get; protected set; }

        public Interval(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public bool IsSubsetOf(Interval interval)
        {
            return interval.Min <= Min && interval.Max >= Max;
        }

        public bool Overlaps(Interval interval)
        {
            return IsSubsetOf(interval) || (interval.Min >= Min && interval.Min <= Max) || (interval.Max >= Min && interval.Max <= Max);
        }
    }
}
