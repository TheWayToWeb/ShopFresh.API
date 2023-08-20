namespace Items.Domain.Components.Payment
{
    public class Payment
    {
        public Guid Id { get; private set; }
        public string? AmountPayable { get; private set; }
        public List<PaymentMethod> PaymentMethods { get; private set; } = new();
    }
}
