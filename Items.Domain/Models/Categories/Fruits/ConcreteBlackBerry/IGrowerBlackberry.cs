using BlackberryDomain = Items.Domain.Models.Categories.Fruits.ConcreteBlackBerry.BlackBerry.Blackberry;

namespace Items.Domain.Models.Categories.Fruits.ConcreteBlackBerry
{
    public interface IGrowerBlackberry
    {
        public BlackberryDomain CreateBlackberry();
    }
}
