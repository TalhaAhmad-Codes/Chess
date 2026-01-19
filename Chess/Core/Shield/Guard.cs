namespace Chess.Core.Shield
{
    public static class Guard
    {
        public static void AgainstNullOrWhitespace(string value, string property)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new DomainException($"{property} can't be null or whitespace.");
        }
    }
}
