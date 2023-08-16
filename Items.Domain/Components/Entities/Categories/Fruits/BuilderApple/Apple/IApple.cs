using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;

namespace Items.Domain.Components.Entities.Categories.Fruits.BuilderApple.Apple
{
    public interface IApple
    {
        void SetGrade(string value);
        void SetSaleWeights(List<SalesLine> value);
    }
}
