using Chess.Core.Shield;

namespace Chess.UI.Misc
{
    public sealed class Decorator
    {
        // Attributes
        public char Value { get; }
        public Color Color { get; }

        // Constructor
        public Decorator(char value, Color color)
        {
            Guard.AgainstWhiteSpace(value, nameof(Decorator));

            Value = value;
            Color = color;
        }

        // Method - Display Method
        public void Display(bool lineBreak = false)
        {
            ColorProperty.Set(Color);

            Console.Write(Value);

            ColorProperty.Reset();

            if (lineBreak) Console.WriteLine();
        }
    }
}
