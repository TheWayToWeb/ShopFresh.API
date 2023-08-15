using DomainWater = Items.Domain.Components.Entities.Categories.Drinks.ConcreteWater.Water.Water;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteWater
{
    public interface IMakerWater
    {
        public DomainWater CreateWater();
    }
}
