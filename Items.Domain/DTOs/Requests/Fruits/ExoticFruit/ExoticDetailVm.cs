using Items.Domain.DTOs.Requests.Common;
using ExoticFruitDomain = Items.Domain.Models.Categories.Fruits.ConcreteExoticFruit.ExoticFruit.ExoticFruit;

namespace Items.Domain.DTOs.Requests.Fruits.ExoticFruit
{
    public class ExoticDetailVm : IMapWith<ExoticFruitDomain>
    {
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int CreatedDate { get; set; }
        public float Weight { get; set; }
        public string? CoolingMode { get; set; }
        public string? Grade { get; set; }
    }
}
