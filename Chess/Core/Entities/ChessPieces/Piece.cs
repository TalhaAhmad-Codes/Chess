using Chess.Core.Shield;

namespace Chess.Core.Entities.ChessPieces
{
    public abstract class Piece
    {
        // Attributes
        public char Symbol { get; }
        
        // Constructor
        public Piece(char symbol)
        {
            Guard.AgainstWhiteSpace(symbol, nameof(symbol));

            Symbol = symbol;
        }

        // Method - Move the piece
        public virtual void Move()
        {

        }
    }
}
