using MediatR;

namespace Items.Application.Products.CreateVegetable
{
    public class CreateVegetable : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public string? Kind { get; set; }
        public int Weight { get; set; }
        public string? Shape { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? Package { get; set; }
        public string? CoolingMode { get; set; }
        public bool IsVitamin { get; set; }
    }
}
