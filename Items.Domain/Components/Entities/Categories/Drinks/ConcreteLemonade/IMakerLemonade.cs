using DomainLemonade = Items.Domain.Components.Entities.Categories.Drinks.ConcreteLemonade.Lemonade.Lemonade;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteLemonade
{
    public interface IMakerLemonade
    {
        public DomainLemonade CreateLemonade();
    }
}
