namespace Chess.Domain.Common.Entities
{
    public abstract class AuditableEntity : BaseEntity
    {
        // Attributes
        public DateTime CreatedAt { get; protected set; } = DateTime.Now;
        public DateTime UpdatedAt { get; protected set; }

        // Method - Mark update log
        protected void MarkUpdated()
            => UpdatedAt = DateTime.Now;
    }
}
