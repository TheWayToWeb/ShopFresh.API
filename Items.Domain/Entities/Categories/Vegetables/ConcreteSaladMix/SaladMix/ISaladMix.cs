using Salad = Items.Domain.Entities.Categories.Vegetables.ConcreteSalad.Salad.Salad;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteSaladMix.SaladMix
{
    public interface ISaladMix
    {
        void AddGreeneryKinds(List<Salad> value);
    }
}
