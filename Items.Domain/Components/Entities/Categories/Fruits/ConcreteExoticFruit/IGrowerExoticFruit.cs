using ExoticFruitDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteExoticFruit.ExoticFruit.ExoticFruit;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteExoticFruit
{
    public interface IGrowerExoticFruit
    {

        ExoticFruitDomain CreateExoticFruit();
    }
}
