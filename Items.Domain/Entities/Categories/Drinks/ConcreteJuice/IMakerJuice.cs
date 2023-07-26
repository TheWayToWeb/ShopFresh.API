using DomainJuice = Items.Domain.Models.Categories.Drinks.ConcreteJuice.Juice.Juice;

namespace Items.Domain.Models.ConcreteJuice
{
    public interface IMakerJuice
    {
        public DomainJuice CreateJuice();
    }
}
