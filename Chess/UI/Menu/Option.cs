using Chess.Core.Shield;
using Chess.UI.Misc;

namespace Chess.UI.Menu
{
    public sealed class Option
    {
        // Attributes
        public string Value { get; }
        public Color ColorInactive { get; }
        public Color ColorHighlight { get; }
        private bool IsHighlighted;

        // Constructors
        public Option(string option, Color colorInactive, Color colorHighlight, bool highlight = false)
        {
            Guard.AgainstNullOrWhiteSpace(option, nameof(Option));

            Value = option;
            ColorInactive = colorInactive;
            ColorHighlight = colorHighlight;
            IsHighlighted = highlight;
        }

        // Method - Toggle highlight flas
        public void ToggleHighlight()
            => IsHighlighted = !IsHighlighted;

        // Method - Display
        public void Display()
        {
            var color = IsHighlighted ? ColorHighlight : ColorInactive;
            var text = new Text(text: Value, color: color);
            text.Display(false);
        }
    }
}
