using MediatR;

namespace Items.Application.Products.CreateMushroom
{
    public class CreateMushroom : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }

    }
}
