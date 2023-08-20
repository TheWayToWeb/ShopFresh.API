namespace Items.Domain.Components.Payment
{
    public class PaymentMethod
    {
        public Guid Id { get; private set; }
        public string? PaymentTypeName { get; private set; }
        public string? AccountNumber { get; private set; }
    }
}
