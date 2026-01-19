using Chess.Shield;

namespace Chess.UI.Text
{
    public sealed class Text
    {
        // Attributes
        private string text;
        public string Value 
        {
            get => text;
            set
            {
                Guard.AgainstNullOrWhitespace(value, nameof(Text));
                text = value;
            }
        }
        public Color? Color { get; set; }

        // Constructor
        public Text(string text, Color? color = null)
        {
            this.text = text;
            Color = color;
        }

        // Method - Display the text
        public void Display(bool lineBreak = true)
        {
            if (Color.HasValue)
                ColorProperty.Set(Color.Value);

            Console.Write(Value);

            ColorProperty.Reset();

            if (lineBreak) Console.WriteLine();
        }
    }
}
