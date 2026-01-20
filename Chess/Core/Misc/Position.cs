using Chess.Core.Shield;
using Chess.UI.Misc;

namespace Chess.Core.Misc
{
    public sealed class Position
    {
        // Attributes
        int row, column;
        
        // Constructor
        public Position(int row, int column)
        {
            Guard.AgainstOutOfRange(row, Range, nameof(row));
            Guard.AgainstOutOfRange(column, Range, nameof(column));

            this.row = row;
            this.column = column;
        }

        // Getters & Setters
        public int Row
        {
            get => row;
            set
            {
                Guard.AgainstOutOfRange(value, Range, nameof(row));

                row = value;
            }
        }

        public int Column
        {
            get => column;
            set
            {
                Guard.AgainstOutOfRange(value, Range, nameof(column));

                column = value;
            }
        }

        public static Range Range
            => new(0, 7);

        // Method - Display Info
        public void DisplayInfo()
        {
            Message.DisplayInfo($"Position: {this}");
        }

        // Method - To string conversion
        public override string ToString()
            => $"({Row}, {Column})";

        /************************************/
        /* Methods - Operators' Overloading */
        /************************************/

        public static Position operator -(Position position, Position value)
            => new(position.Row - value.Row, position.Column - value.Column);

        public static Position operator +(Position position, Position value)
            => new(position.Row + value.Row, position.Column + value.Column);
    }
}
