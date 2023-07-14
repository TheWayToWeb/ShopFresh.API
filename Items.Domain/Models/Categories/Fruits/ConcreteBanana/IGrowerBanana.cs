using BananaDomain = Items.Domain.Models.Categories.Fruits.ConcreteBanana.Banana.Banana;

namespace Items.Domain.Models.Categories.Fruits.ConcreteBanana
{
    public interface IGrowerBanana
    {
        public BananaDomain CreateBanana();
    }
}
