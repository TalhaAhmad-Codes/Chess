using Chess.Shield;

namespace Chess.UI.Text
{
    public class Text
    {
        // Attributes
        protected string text;
        public string Value 
        {
            get => text;
            set
            {
                Guard.AgainstNullOrWhitespace(value, nameof(Text));
                text = value.Trim();
            }
        }
        public Color? Color { get; set; }

        // Constructors
        public Text(string text, Color? color = null)
        {
            this.text = text;
            Color = color;
        }
        public Text(Text text)
        {
            this.text = text.Value;
            Color = (text.Color is null) ? null : new(text.Color);
        }

        // Method - Display the text
        public virtual void Display(bool lineBreak = true)
        {
            if (Color != null)
                ColorProperty.Set(Color);

            Console.Write(Value);

            ColorProperty.Reset();

            if (lineBreak) Console.WriteLine();
        }
    }
}
