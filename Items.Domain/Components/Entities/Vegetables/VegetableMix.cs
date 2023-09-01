using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.Vegetables
{
    public class VegetableMix : ItemFood
    {
        public List<Vegetable> Vegetables { get; private set; } = new();
    }
}
