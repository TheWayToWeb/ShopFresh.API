using Items.Domain.Components.Entities.Categories.Vegetables.BuilderSaladMix.SaladMix;
using Items.Domain.Components.Entities.Categories.Vegetables.Vegetable;
using SelfSaladMix = Items.Domain.Components.Entities.Categories.Vegetables.BuilderSaladMix.SaladMix.SaladMix;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderSaladMix
{
    public interface IBuilderSaladMix : IVegetable, ISaladMix
    {
        void SetPrice(int value);
        void SetImagePath(string value);
        void SetMaker(string value);
        void SetMinTemp(int value);
        void SetMaxTemp(int value);
        void SetProtein(float value);
        void SetFat(float value);
        void SetSugar(float value);
        void SetEnergy(float value);
        void SetCountInPackage(int value);
        void SetCreatedDate(int value);
        void SetWeight(float value);
        void SetCoolingMode(string value);
        SelfSaladMix CreateSaladMix();
    }
}
