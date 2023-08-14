using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.ConcretePotato.Potato
{
    public interface IPotato
    {
        void AddSaleWeights(List<Line> value);
        void SetIsWash(bool value);
    }
}
