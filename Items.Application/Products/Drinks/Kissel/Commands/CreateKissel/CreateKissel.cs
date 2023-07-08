using Items.Domain.Products.Template;
using MediatR;

namespace Items.Application.Products.Drinks.Kissel.Commands.CreateKissel
{
    public class CreateKissel : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string ItemName { get; set; } = "";
        public int Price { get; set; }
        public string ImagePath { get; set; } = "";
    }
}
