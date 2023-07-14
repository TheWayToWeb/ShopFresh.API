using ExoticFruitDomain = Items.Domain.Models.Categories.Fruits.ConcreteExoticFruit.ExoticFruit.ExoticFruit;

namespace Items.Domain.Models.Categories.Fruits.ConcreteExoticFruit
{
    public interface IGrowerExoticFruit
    {
        public ExoticFruitDomain CreateExoticFruit();
    }
}
