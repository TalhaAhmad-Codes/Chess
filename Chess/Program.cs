using Chess.Core.Entities;
using Chess.Core.Enums;
using Chess.Core.Misc;
using Chess.Core.Shield;
using Chess.UI.Menu;
using Chess.UI.Misc;

namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseMenu menu = new(
            //    header: new(
            //        text: "Main Menu", new(
            //            fg: ConsoleColor.DarkGreen
            //        )
            //    ),
            //    decorator: new(
            //        value: '=', color: new(
            //            fg: ConsoleColor.DarkYellow
            //        )
            //    ),
            //    optionInactiveColor: new(
            //        fg: ConsoleColor.DarkCyan
            //    ),
            //    optionHighlightColor: new(
            //        fg: ConsoleColor.White,
            //        bg: ConsoleColor.DarkCyan
            //    )
            //);

            //menu.AddOption("Start Game");
            //menu.AddOption("Load Game");
            //menu.AddOption("Options");
            //menu.AddOption("Credits");
            //menu.AddOption("Exit");

            //menu.Display();

            try
            {
                //// Player #1
                //Player player1 = new(
                //    name: "Talha Ahmad",
                //    group: Group.White,
                //    score: 150
                //);

                //player1.IncrementScore(4);
                //player1.DecrementScore(10);

                //player1.DisplayInfo();

                //// Player #2
                //Player player2 = new(
                //    name: "M. Raza",
                //    group: Group.Black,
                //    score: 125
                //);

                //player2.IncrementScore(4);
                //player2.DecrementScore(9);

                //player2.DisplayInfo();

                Position pos1 = new(
                    row: 0,
                    column: 2
                ),
                pos2 = new(
                    row: 1,
                    column: 3
                );

                var result = pos1 + pos2;

                pos1.DisplayInfo();
                pos2.DisplayInfo();
                result.DisplayInfo();
            }
            catch (DomainException e)
            {
                Message.DisplayError(e.Message);
            }
        }
    }
}
