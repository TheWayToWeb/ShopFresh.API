using PearDomain = Items.Domain.Models.Categories.Fruits.ConcretePear.Pear.Pear;

namespace Items.Domain.Models.Categories.Fruits.ConcretePear
{
    public interface IGrowerPear
    {
        PearDomain CreatePear();
    }
}
