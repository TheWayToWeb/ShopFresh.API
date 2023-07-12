using DomainKissel = Items.Domain.Models.Categories.Drinks.ConcreteKissel.Kissel.Kissel;

namespace Items.Domain.Models.ConcreteKissel
{
    public interface IMakerKissel
    {
        public DomainKissel CreateKissel();
    }
}
