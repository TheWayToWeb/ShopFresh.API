using DomainCoffee = Items.Domain.Models.Categories.Drinks.ConcreteCoffee.Coffee.Coffee;

namespace Items.Domain.Models.Categories.Drinks.ConcreteCoffee
{
    public interface IMakerCoffee
    {
        public DomainCoffee CreateCoffee();
    }
}
