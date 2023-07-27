using BlackberryDomain = Items.Domain.Entities.Categories.Fruits.ConcreteBlackBerry.BlackBerry.Blackberry;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteBlackBerry
{
    public interface IGrowerBlackberry
    {
        BlackberryDomain CreateBlackberry();
    }
}
