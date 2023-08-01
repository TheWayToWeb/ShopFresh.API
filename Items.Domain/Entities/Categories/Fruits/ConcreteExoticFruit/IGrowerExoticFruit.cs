using ExoticFruitDomain = Items.Domain.Entities.Categories.Fruits.ConcreteExoticFruit.ExoticFruit.ExoticFruit;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteExoticFruit
{
    public interface IGrowerExoticFruit
    {

        ExoticFruitDomain CreateExoticFruit();
    }
}
