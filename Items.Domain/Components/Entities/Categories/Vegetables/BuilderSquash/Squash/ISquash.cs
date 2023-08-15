using Line = Items.Domain.Components.Entities.Categories.Vegetables.Common.SalesRange;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderSquash.Squash
{
    public interface ISquash
    {
        void AddSaleWeights(List<Line> value);
    }
}
