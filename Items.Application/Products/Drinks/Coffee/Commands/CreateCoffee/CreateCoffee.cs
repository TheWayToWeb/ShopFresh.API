using MediatR;

namespace Items.Application.Products.Drinks.Coffee.Commands.CreateCoffee
{
    public class CreateCoffee : IRequest<Guid> {
        public Guid PersonId { get; set; }
        public string ItemName { get; set; } = "";
        public int Price { get; set; }
        public string ImagePath { get; set; } = "";
    }
}
