using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Vegetables
{
    public class VegetableMix : Eat
    {
        public List<Vegetable> Vegetables { get; set; } = new();
    }
}
