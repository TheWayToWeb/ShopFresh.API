using SalesRange = Items.Domain.Components.Entities.Categories.Vegetables.Common.SalesRange;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderCarrot.Carrot
{
    public interface ICarrot
    {
        void AddSaleWeights(List<SalesRange> value);
        void SetWash(bool value);
    }
}
