using SalesRange = Items.Domain.Components.Entities.Categories.Vegetables.Common.SalesRange;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderCabbage.Cabbage
{
    public interface ICabbage
    {
        void AddSaleWeights(List<SalesRange> value);
    }
}
