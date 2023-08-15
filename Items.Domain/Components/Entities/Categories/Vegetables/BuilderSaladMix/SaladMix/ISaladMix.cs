using SelfSalad = Items.Domain.Components.Entities.Categories.Vegetables.BuilderSalad.Salad.Salad;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderSaladMix.SaladMix
{
    public interface ISaladMix
    {
        void AddGreeneryKinds(List<SelfSalad> value);
    }
}
