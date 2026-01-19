namespace Chess.UI.Misc
{
    public static class Func
    {
        public static void DisplayLine(Decorator decorator, int size, bool lineBreak = true)
        {
            for (int i = 0; i < size; i++)
                decorator.Display();

            if (lineBreak) Console.WriteLine();
        }

        public static void PrintGap(int size = 1)
        {
            for (int i = 0; i < size; i++)
                Console.Write(' ');
        }
    }
}
