using BroccoliDomain = Items.Domain.Entities.Categories.Vegetables.ConcreteBroccoli.Broccoli.Broccoli;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBroccoli
{
    public interface IGrowerBroccoli
    {
        BroccoliDomain CreateBroccoli();
    }
}
