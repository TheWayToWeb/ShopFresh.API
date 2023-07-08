using MediatR;

namespace Items.Application.Products.Drinks.PackageTea.Commands.DryTea.Commands.CreateDryTea
{
    public class CreatePackageTea : IRequest<Guid>
    {
        public Guid PersonId { get; set; }
        public string ItemName { get; set; } = "";
        public int Price { get; set; }
        public string ImagePath { get; set; } = "";
    }
}
