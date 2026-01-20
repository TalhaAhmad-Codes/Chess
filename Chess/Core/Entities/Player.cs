using Chess.Core.Enums;
using Chess.Core.Shield;
using Chess.UI.Misc;

namespace Chess.Core.Entities
{
    public sealed class Player
    {
        // Attributes
        public string Name { get; }
        public int Score { get; private set; }
        public Group Group { get; }
        
        // Constructor
        public Player(string name, Group group, int score = 0)
        {
            Guard.AgainstNullOrWhiteSpace(name, nameof(name));
            Guard.AgainstNegative(score, nameof(score));
            
            Name = name.Trim();
            Group = group;
            Score = score;
        }

        // Method - Increase Score
        public void IncrementScore(int value = 1)
        {
            Guard.AgainstZeroOrLess(value, $"increment {nameof(value)}");

            Score += value;
        }

        public void DecrementScore(int value = 1)
        {
            Guard.AgainstZeroOrLess(value, $"decrement {nameof(value)}");
            Guard.AgainstNegative(Score - value, nameof(Score));

            Score -= value;
        }

        // Method - Display
        public void DisplayInfo()
        {
            var info = $"Name: {Name} | Score: {Score} | Group: {Group.ToString()}";
            Message.DisplayInfo(info);
        }
    }
}
