namespace Chess.UI.Text
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

        public static void Info(string message)
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

        public static void Error(string message)
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
    }
}
