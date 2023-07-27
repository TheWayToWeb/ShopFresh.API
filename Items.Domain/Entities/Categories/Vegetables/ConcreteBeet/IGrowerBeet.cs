using BeetDomain = Items.Domain.Entities.Categories.Vegetables.ConcreteBeet.Beet.Beet;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBeet
{
    public interface IGrowerBeet
    {
        BeetDomain CreateBeet();
    }
}
