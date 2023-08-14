using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.BuilderCabbage.Cabbage
{
    public interface ICabbage
    {
        void AddSaleWeights(List<Line> value);
    }
}
