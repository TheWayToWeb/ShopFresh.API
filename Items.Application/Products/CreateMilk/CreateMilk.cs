using MediatR;

namespace Items.Application.Products.CreateMilk
{
    public class CreateMilk : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public List<float> FatContent { get; set; } = new();
        public List<int> Capacity { get; set; } = new();
        public string? Raw { get; set; }
        public string? Kind { get; set; }
        public bool IsFarmer { get; set; }
    }
}
