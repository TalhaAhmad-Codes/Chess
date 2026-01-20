using Chess.Core.Misc;

namespace Chess.Core.Shield
{
    public static class Guard
    {
        public static void AgainstNullOrWhiteSpace(string value, string property)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new DomainException($"{Func.CapitalizeString(property)} can't be null or whitespace.");
        }

        public static void AgainstWhiteSpace(char value, string property)
        {
            if (value == ' ' || value == '\t' || value == '\n' || value == '\b')
                throw new DomainException($"{Func.CapitalizeString(property)} can't be whitespace.");
        }

        public static void AgainstOutOfRange(int value, Misc.Range range, string property)
        {
            if (value < range.Start || value > range.End)
                throw new DomainException($"{Func.CapitalizeString(property)} is out of range {range}");
        }

        public static void AgainstZeroOrLess(int value, string property)
        {
            if (value <= 0)
                throw new DomainException($"{Func.CapitalizeString(property)} can't be zero or negative.");
        }

        public static void AgainstNegative(int value, string property)
        {
            if (value < 0)
                throw new DomainException($"{Func.CapitalizeString(property)} can't be negative.");
        }
    }
}
