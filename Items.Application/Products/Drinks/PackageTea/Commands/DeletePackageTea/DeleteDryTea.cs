using MediatR;

namespace Items.Application.Products.Drinks.PackageTea.Commands.DryTea.Commands.DeleteDryTea
{
    public class DeleteDryTea : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}
