using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderBanana.Banana
{
    public interface IBanana
    {
        void SetSaleWeights(List<SalesLine> value);
    }
}
