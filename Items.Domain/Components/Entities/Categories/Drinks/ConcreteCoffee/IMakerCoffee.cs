using DomainCoffee = Items.Domain.Components.Entities.Categories.Drinks.ConcreteCoffee.Coffee.Coffee;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteCoffee
{
    public interface IMakerCoffee
    {
        public DomainCoffee CreateCoffee();
    }
}
