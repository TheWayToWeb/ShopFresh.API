using MediatR;

namespace Items.Application.Products.Bakery.RollCake.Commands.CreateRollCake
{
    public class CreateRollCake : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string ItemName { get; set; } = "";
        public int Price { get; set; }
        public string ImagePath { get; set; } = "";
    }
}
