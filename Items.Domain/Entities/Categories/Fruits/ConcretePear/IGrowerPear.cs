using PearDomain = Items.Domain.Entities.Categories.Fruits.ConcretePear.Pear.Pear;

namespace Items.Domain.Entities.Categories.Fruits.ConcretePear
{
    public interface IGrowerPear
    {
        PearDomain CreatePear();
    }
}
