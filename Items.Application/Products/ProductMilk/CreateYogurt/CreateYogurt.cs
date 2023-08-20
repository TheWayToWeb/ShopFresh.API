using Items.Domain.Components.Entities.Common;
using MediatR;

/*Йогурты в свою очередь тоже абстракция*/

namespace Items.Application.Products.ProductMilk.CreateYogurt
{
    public class CreateYogurt : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float? Weight { get; set; }
        public List<SoldCapacity>? Capacity { get; set; } = new();
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public bool IsLactoseFree { get; set; }
        public bool IsFarmer { get; set; }
        public bool IsVegan { get; set; }
        public bool IsBestseller { get; set; }
        public List<ProductTaste>? Tastes { get; set; } = new();
        public float FatContent { get; set; }
    }
}
