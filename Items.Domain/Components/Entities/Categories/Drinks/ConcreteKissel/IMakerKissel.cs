using DomainKissel = Items.Domain.Components.Entities.Categories.Drinks.ConcreteKissel.Kissel.Kissel;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteKissel
{
    public interface IMakerKissel
    {
        public DomainKissel CreateKissel();
    }
}
