using Chess.Core.Shield;

namespace Chess.UI.Misc
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
                Guard.AgainstNullOrWhiteSpace(value, nameof(Text));
                
                text = value.Trim();
            }
        }
        public Color? Color { get; set; }

        // Constructors
        public Text(string text, Color? color = null)
        {
            Guard.AgainstNullOrWhiteSpace(text, nameof(Text));
            this.text = text.Trim();

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

            if (lineBreak) Func.LineBreak();
        }
    }
}
