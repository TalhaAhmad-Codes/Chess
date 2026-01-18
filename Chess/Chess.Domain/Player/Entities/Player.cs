using Chess.Domain.Common.Entities;

namespace Chess.Domain.Player.Entities
{
    public sealed class Player : AuditableEntity
    {
        // Attributes
        public string Name { get; private set; }
    }
}
