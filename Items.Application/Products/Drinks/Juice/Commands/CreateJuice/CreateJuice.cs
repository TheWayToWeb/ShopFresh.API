using MediatR;

namespace Items.Application.Products.Drinks.Juice.Commands.CreateJuice
{
    public class CreateJuice : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string ItemName { get; set; } = "";
        public int Price { get; set; }
        public string ImagePath { get; set; } = "";
    }
}
