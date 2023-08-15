using DomainSoyMilk = Items.Domain.Components.Entities.Categories.Drinks.ConcreteSoyMilk.SoyMilk.SoyMilk;

namespace Items.Domain.Components.Entities.Categories.Drinks.ConcreteSoyMilk
{
    public interface IMakerSoyMilk
    {
        public DomainSoyMilk CreateSoyMilk();
    }
}
