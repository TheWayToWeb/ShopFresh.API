using Items.Domain.Components.Entities.Common;
using MediatR;

namespace Items.Application.Items.Commands.CreateItem
{
    public class CreateItemFoodRequest : IRequest<Guid>
    {
        public Guid ItemId { get; set; }
        public Guid BrandId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int CountInPackage { get; set; }
        public float Weight { get; set; }
        public string? Description { get; set; }
    }
}
