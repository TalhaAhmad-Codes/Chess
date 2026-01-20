using Chess.Core.Shield;
using Chess.UI.Misc;

namespace Chess.Core.Misc
{
    public sealed class Range
    {
        // Attributes
        public int Start { get; }
        public int End { get; }

        // Constructor
        public Range(int start, int end)
        {
            Guard.AgainstNegative(start, nameof(start));
            Guard.AgainstNegative(end, nameof(end));

            Start = start;
            End = end;
        }

        // Method - Display the range
        public void DisplayInfo()
        {
            Message.DisplayInfo($"Range: {this}");
        }

        // Method - Convert to string
        public override string ToString()
            => $"({Start}, {End})";
    }
}
