using CherryDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteCherry.Cherry.Сherry;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteCherry
{
    public interface IGrowerCherry
    {
        CherryDomain CreateCherry();
    }
}
