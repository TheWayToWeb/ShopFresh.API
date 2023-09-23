using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Orders.Common;

namespace Items.Domain.Components.Orders
{
    public class BookingDetails
    {
        public Guid Id { get; set; }
        public float OrderPrice { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime ReceivingDate { get; set; }
        public Guid AddressId { get; set; }
        public Address? Address { get; set; }
        public Guid OrderId { get; set; }
        public Booking? Order { get; set; }
    }
}
