using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderCitrus.Citrus
{
    public interface ICitrus
    {
        void SetSalesWeights(List<SalesLine> value);
    }
}
