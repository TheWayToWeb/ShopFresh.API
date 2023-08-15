using DomainJuice = Items.Domain.Components.Entities.Categories.Drinks.ConcreteJuice.Juice.Juice;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteJuice
{
    public interface IMakerJuice
    {
        public DomainJuice CreateJuice();
    }
}
