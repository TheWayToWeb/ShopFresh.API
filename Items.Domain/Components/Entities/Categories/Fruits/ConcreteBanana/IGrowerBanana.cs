using BananaDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcreteBanana.Banana.Banana;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcreteBanana
{
    public interface IGrowerBanana
    {
        BananaDomain CreateBanana();
    }
}
