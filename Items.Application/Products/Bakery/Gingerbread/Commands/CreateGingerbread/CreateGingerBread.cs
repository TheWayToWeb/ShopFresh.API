using MediatR;

namespace Items.Application.Products.Bakery.Gingerbread.Commands.CreateGingerbread
{
    public class CreateGingerBread : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackge { get; set; }
        public int ProductExpiryDate { get; set; }
        public float? Weight { get; set; }
        public string? ProductBakeryKind { get; set; }
        public string? ProductKindItSelf { get; set; }
    }
}
