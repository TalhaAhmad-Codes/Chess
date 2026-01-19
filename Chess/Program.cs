using Chess.UI.Menu;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseMenu menu = new(
                header: new(
                    text: "Main Menu", new(
                        fg: ConsoleColor.DarkGreen
                    )
                ),
                decorator: new(
                    value: '=', color: new(
                        fg: ConsoleColor.DarkYellow
                    )
                ),
                optionInactiveColor: new(
                    fg: ConsoleColor.DarkCyan
                ),
                optionHighlightColor: new(
                    fg: ConsoleColor.White,
                    bg: ConsoleColor.DarkCyan
                )
            );

            menu.AddOption("Start Game");
            menu.AddOption("Load Game");
            menu.AddOption("Options");
            menu.AddOption("Credits");
            menu.AddOption("Exit");

            menu.Display();
        }
    }
}
