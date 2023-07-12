using DomainLemonade = Items.Domain.Models.Categories.Drinks.ConcreteLemonade.Lemonade.Lemonade;

namespace Items.Domain.Models.Categories.Drinks.ConcreteLemonade
{
    public interface IMakerLemonade
    {
        public DomainLemonade CreateLemonade();
    }
}
