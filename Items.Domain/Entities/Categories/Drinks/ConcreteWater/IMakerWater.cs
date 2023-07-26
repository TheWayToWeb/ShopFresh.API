using DomainWater = Items.Domain.Models.Categories.Drinks.ConcreateWater.Water.Water;

namespace Items.Domain.Models.Categories.Drinks.ConcreteWater
{
    public interface IMakerWater
    {
        public DomainWater CreateWater();
    }
}
