using MediatR;

namespace Items.Application.ItemsFood.Commands.UpdateItemFood
{
    public class UpdateItemFoodRequest : IRequest<Unit>
    {
        public Guid ItemId { get; set; }
        public Guid BrandId { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
        public string Maker { get; set; }
        public int CountInPackage { get; set; }
        public float Weight { get; set; }
        public string Description { get; set; }
    }
}
