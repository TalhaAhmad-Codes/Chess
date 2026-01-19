namespace Chess.UI.Misc
{
    public class Color
    {
        // Properties
        public ConsoleColor ForegroundColor { get; }
        public ConsoleColor? BackgroundColor { get; }

        // Constructors
        public Color(ConsoleColor fg, ConsoleColor? bg = null)
        {
            ForegroundColor = fg;
            BackgroundColor = bg;
        }

        public Color(Color color)
        {
            ForegroundColor = color.ForegroundColor;
            BackgroundColor = color.BackgroundColor;
        }
    }

    public static class ColorProperty
    {
        public static void Set(Color color)
        {
            Console.ForegroundColor = color.ForegroundColor;

            if (color.BackgroundColor.HasValue)
                Console.BackgroundColor = color.BackgroundColor.Value;
        }

        public static void Reset()
        {
            Console.ResetColor();
        }
    }
}
