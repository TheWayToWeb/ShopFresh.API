using BananaDomain = Items.Domain.Entities.Categories.Fruits.ConcreteBanana.Banana.Banana;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteBanana
{
    public interface IGrowerBanana
    {
        BananaDomain CreateBanana();
    }
}
