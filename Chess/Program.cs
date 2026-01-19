using Chess.UI.Text;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Text example
            Text text = new(
                text: "Talha Ahmad",
                color: new(
                    fg: ConsoleColor.DarkRed, bg: ConsoleColor.Green
                )
            );

            text.Display();
        }
    }
}
