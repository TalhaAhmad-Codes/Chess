namespace Chess.UI.Text
{
    public struct Color
    {
        public ConsoleColor ForegroundColor { get; }
        public ConsoleColor? BackgroundColor { get; }

        public Color(ConsoleColor fg, ConsoleColor? bg)
        {
            ForegroundColor = fg;
            BackgroundColor = bg;
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
