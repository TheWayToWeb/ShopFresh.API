using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.BuilderCarrot.Carrot
{
    public interface ICarrot
    {
        void AddSaleWeights(List<Line> value);
        void SetWash(bool value);
    }
}
