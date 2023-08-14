using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteSquash.Squash
{
    public interface ISquash
    {
        void AddSaleWeights(List<Line> value);
    }
}
