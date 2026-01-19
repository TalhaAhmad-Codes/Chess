using Chess.Core.Shield;
using Chess.UI.Misc;

namespace Chess.UI.Menu
{
    public class BaseMenu
    {
        // Attributes
        public Decorator Decorator { get; }
        public Text Header { get; }
        public Color OptionInactiveColor { get; }
        public Color OptionHighlightColor { get; }
        public List<Option> Options { get; private set; }
        private int MaxLength;

        // Constructors
        public BaseMenu(Text header, Decorator decorator, Color optionInactiveColor, Color optionHighlightColor)
        {
            Header = header;
            Decorator = decorator;
            Options = new List<Option>();
            OptionInactiveColor = optionInactiveColor;
            OptionHighlightColor = optionHighlightColor;
            MaxLength = header.Value.Length;
        }

        // Method - Add an option
        public void AddOption(string option)
        {
            bool highlight = Options.Count == 0;
            int optionLength = option.Length;
        
            Options.Add(new(
                option: option,
                colorInactive: OptionInactiveColor,
                colorHighlight: OptionHighlightColor,
                highlight
            ));

            if (optionLength > MaxLength)
                MaxLength = optionLength;
        }

        // Method - Display
        public void Display()
        {
            /*// <----- Header -----> //*/

            var padding = MaxLength - Header.Value.Length + 1;

            // Decorator line # 1
            Func.DisplayLine(Decorator, MaxLength + 4);

            Decorator.Display();        // Left Decorator - Border
            Func.PrintGap();            // Left Gap
            Header.Display(false);      // Header
            Func.PrintGap(padding);     // Right Gap
            Decorator.Display(true);    // Right Decorator - Border

            // Decorator line # 2
            Func.DisplayLine(Decorator, MaxLength + 4);

            /*// <----- Options -----> //*/

            foreach (var option in Options)
            {
                // Padding
                padding = MaxLength - option.Value.Length + 1;

                Decorator.Display();        // Left Decorator - Border
                Func.PrintGap();            // Left Gap
                option.Display();           // Option
                Func.PrintGap(padding);     // Right Gap
                Decorator.Display(true);    // Right Decorator - Border
            }

            // Decorator line # 3
            Func.DisplayLine(Decorator, MaxLength + 4);
        }
    }
}
