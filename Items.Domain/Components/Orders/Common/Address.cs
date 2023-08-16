namespace Items.Domain.Components.Orders.Common
{
    public class Address
    {
        public Guid Id { get; private set; }
        public string? City { get; private set; }
        public string? Region { get; private set; }
        public string? Country { get; private set; }
        public string? PostCode { get; private set; }
        // public Person Person { get; set; }
    }
}
