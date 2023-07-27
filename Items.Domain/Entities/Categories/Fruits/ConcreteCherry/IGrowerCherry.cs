using CherryDomain = Items.Domain.Entities.Categories.Fruits.ConcreteCherry.Cherry.Сherry;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteCherry
{
    public interface IGrowerCherry
    {
        CherryDomain CreateCherry();
    }
}
