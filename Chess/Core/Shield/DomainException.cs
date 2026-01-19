namespace Chess.Core.Shield
{
    public sealed class DomainException : Exception
    {
        public DomainException(string message) : base (message) {}
    }
}
