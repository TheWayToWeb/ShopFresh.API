using BlackberryDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteBlackBerry.BlackBerry.Blackberry;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteBlackBerry
{
    public interface IGrowerBlackberry
    {
        BlackberryDomain CreateBlackberry();
    }
}
