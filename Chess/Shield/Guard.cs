namespace Chess.Shield
{
    public static class Guard
    {
        public static void AgainstNullOrWhitespace(string value, string property)
        {
            if (string.IsNullOrEmpty(value))
                throw new DomainException($"{property} can't be null or whitespace.");
        }
    }
}
