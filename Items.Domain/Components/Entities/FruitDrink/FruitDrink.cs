using Items.Domain.Components.Entities.Common;

namespace Items.Domain.Components.Entities.FruitDrink
{
    public class FruitDrink : ItemFood
    {
        public List<ProductTaste> Tastes { get; private set; } = new();
        public List<SoldCapacity> Volume { get; private set; } = new();
        public int AgeLimit { get; set; }
        public bool IsCold { get; private set; }
    }
}
