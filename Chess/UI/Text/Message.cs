namespace Chess.UI.Text
{
    public static class MessageHeader
    {
        public static Text INFO => new(
                text: "[INFO]", new(
                        fg: ConsoleColor.DarkBlue,
                        bg: ConsoleColor.Cyan
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
            // Set BackGround color
            //if (Header.Color != null && Header.Color.BackgroundColor.HasValue)
            //    Console.BackgroundColor = Header.Color.BackgroundColor.Value;

            // Print gap
            Console.Write(' ');

            // Reset the color
            //ColorProperty.Reset();
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
    }
}
