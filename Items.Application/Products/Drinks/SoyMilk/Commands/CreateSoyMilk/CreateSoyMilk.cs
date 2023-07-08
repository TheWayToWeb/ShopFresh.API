using MediatR;

namespace Items.Application.Products.Drinks.SoyMilk.Commands.CreateSoyMilk
{
    public class CreateSoyMilk : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string ItemName { get; set; } = "";
        public int Price { get; set; }
        public string ImagePath { get; set; } = "";
    }
}
