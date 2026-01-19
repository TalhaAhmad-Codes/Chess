namespace Chess.UI.Misc
{
    public static class MessageHeader
    {
        public static Text INFO => new(
            text: "[INFO]", new(
                fg: ConsoleColor.White,
                bg: ConsoleColor.DarkBlue
            )
        );

        public static Text ERROR => new(
            text: "[ERROR]", new(
                fg: ConsoleColor.White,
                bg: ConsoleColor.DarkRed
            )
        );

        public static Text WARNING => new(
            text: "[WARNING]", new(
                fg: ConsoleColor.White,
                bg: ConsoleColor.DarkYellow
            )
        );

        public static Text DEBUG => new(
            text: "[DEBUG]", new(
                fg: ConsoleColor.White,
                bg: ConsoleColor.DarkGray
            )
        );

        public static Text SUCCESS => new(
            text: "[SUCCESS]", new(
                fg: ConsoleColor.White,
                bg: ConsoleColor.DarkGreen
            )
        );
    }

    public sealed class Message : Text
    {
        // Attribute
        public Text Header { get; }

        // Constructor
        public Message(Text header, Text message) : base(message)
            => Header = header;

        // Method - Print a gap
        private void Gap()
        {
            // Print gap
            Console.Write(' ');
        }

        // Method - Display the message
        public override void Display(bool lineBreak = true)
        {
            Header.Display(false);      // Header
            Gap();                      // Gap
            base.Display(lineBreak);    // Message
        }

        /**************************************/
        /* Methods - Print different messages */
        /**************************************/

        public static void DisplayInfo(string message)
        {
            Message msg = new(
                header: MessageHeader.INFO,
                message: new(
                    text: message,
                    color: new(fg: ConsoleColor.DarkCyan)
                )
            );

            msg.Display(true);
        }

        public static void DisplayError(string message)
        {
            Message msg = new(
                header: MessageHeader.ERROR,
                message: new(
                    text: message,
                    color: new(fg: ConsoleColor.Red)
                )
            );

            msg.Display(true);
        }

        public static void DisplayWarning(string message)
        {
            Message msg = new(
                header: MessageHeader.WARNING,
                message: new(
                    text: message,
                    color: new(fg: ConsoleColor.Yellow)
                )
            );

            msg.Display(true);
        }

        public static void DisplayDebug(string message)
        {
            Message msg = new(
                header: MessageHeader.DEBUG,
                message: new(
                    text: message,
                    color: new(fg: ConsoleColor.Gray)
                )
            );

            msg.Display(true);
        }

        public static void DisplaySuccess(string message)
        {
            Message msg = new(
                header: MessageHeader.SUCCESS,
                message: new(
                    text: message,
                    color: new(fg: ConsoleColor.Green)
                )
            );

            msg.Display(true);
        }
    }
}
