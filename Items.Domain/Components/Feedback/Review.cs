using Items.Domain.Components.Items;
using Items.Domain.Components.Person;

namespace Items.Domain.Components.Feedback
{
    public class Review
    {
        public Guid Id { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
