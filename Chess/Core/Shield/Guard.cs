namespace Chess.Core.Shield
{
    public static class Guard
    {
        public static void AgainstNullOrWhiteSpace(string value, string property)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new DomainException($"{property} can't be null or whitespace.");
        }

        public static void AgainstWhiteSpace(char value, string property)
        {
            if (value == ' ' || value == '\t' || value == '\n' || value == '\b')
                throw new DomainException($"{property} can't be whitespace.");
        }

        public static void AgainstOutOfRange(int value, int rangeStart, int rangeEnd, string property)
        {
            if (value < rangeStart || value > rangeEnd)
                throw new DomainException($"{property} is out of range ({rangeStart}, {rangeEnd})");
        }

        public static void AgainstZeroOrLess(int value, string property)
        {
            if (value <= 0)
                throw new DomainException($"{property} can't be zero or negative.");
        }
    }
}
