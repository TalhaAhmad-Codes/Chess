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

            // Message examle
            //Message message = new(
            //    header: MessageHeader.INFO,
            //    message: new(
            //            text: "This message is for providing information.",
            //            color: new(fg: ConsoleColor.DarkCyan)
            //        )
            //);

            //message.Display(true);
            Message.Info("This message is for providing information.");
        }
    }
}
