using Items.Domain.Components.Items;
using Items.Domain.Components.Person;

namespace Items.Domain.Components.Promocode
{
    public class Promocode
    {
        public Guid Id { get; private set; }
        public string? DiscountCode { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime FinishDate { get; private set; }
        public bool IsActivePromoCode { get; private set; }
        public Guid UserId { get; private set; }
        public User? User { get; set; }
        public Guid ItemId { get; private set; }
        public Item? Item { get; set; }
    }
}
