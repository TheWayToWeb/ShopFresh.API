using SalesRange = Items.Domain.Components.Entities.Categories.Vegetables.Common.SalesRange;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderPotato.Potato
{
    public interface IPotato
    {
        void AddSaleWeights(List<SalesRange> value);
        void SetIsWash(bool value);
    }
}
