using Items.Domain.Components.Entities.Categories.Common;

namespace Items.Domain.Review
{
    public class Review
    {
        public Guid ReviewId { get; private set; }
        public Guid PersonId { get; private set; }
        public Guid ItemId { get; private set; }
        public int Rating { get; private set; }
        public string? Description { get; private set; }
        // public Person Person { get; set; }
        public Item? Item { get; set; }
    }
}
