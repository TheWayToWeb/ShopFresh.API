using MediatR;

namespace Items.Application.Products.CreateEggs
{
    public class CreateEgg : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int Count { get; set; }
        public string? Kind { get; set; }
        public string? Category { get; set; }
        public bool IsFarmer { get; set; }
    }
}
