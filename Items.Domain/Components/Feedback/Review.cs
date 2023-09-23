using Items.Domain.Components.Items;
using Items.Domain.Components.Person;

namespace Items.Domain.Components.Feedback
{
    public class Review
    {
        public Guid Id { get; private set; }
        public int Rating { get; private set; }
        public string? Description { get; private set; }
        public Guid UserId { get; private set; }
        public User? User { get; set; }
        public Guid ItemId { get; private set; }
        public Item? Item { get; set; }
    }
}
