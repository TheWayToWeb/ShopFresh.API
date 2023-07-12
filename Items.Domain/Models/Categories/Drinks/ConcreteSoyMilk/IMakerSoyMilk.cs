using DomainSoyMilk = Items.Domain.Models.Categories.Drinks.ConcreteSoyMilk.SoyMilk.SoyMilk;

namespace Items.Domain.Models.ConcreteSoyMilk
{
    public interface IMakerSoyMilk
    {
        public DomainSoyMilk CreateSoyMilk();
    }
}
