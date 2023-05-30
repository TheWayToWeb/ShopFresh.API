using MediatR;

namespace Items.Application.Products.CreateCheese
{
    public class CreateCheese : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public string? Kind { get; set; }
        public string? Type { get; set; }
        public string? Shape { get; set; }
        public string? Raw { get; set; }
        public bool IsFarmer { get; set; }
    }
}
