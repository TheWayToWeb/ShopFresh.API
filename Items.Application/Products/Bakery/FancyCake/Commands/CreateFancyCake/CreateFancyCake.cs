using MediatR;

namespace Items.Application.Products.Bakery.FancyCake.Commands.CreateFancyCake
{
    public class CreateFancyCake : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? ProductBakeryKind { get; set; }
        public string? CoolingMode { get; set; }
        public string? ProductKindItSelf { get; set; }
        public string? ProductTypeItSelf { get; set; }
    }
}
