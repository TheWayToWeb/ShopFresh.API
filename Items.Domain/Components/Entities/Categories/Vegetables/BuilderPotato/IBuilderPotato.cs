using Items.Domain.Components.Entities.Categories.Vegetables.BuilderPotato.Potato;
using Items.Domain.Components.Entities.Categories.Vegetables.Vegetable;
using SelfPotato = Items.Domain.Components.Entities.Categories.Vegetables.BuilderPotato.Potato.Potato;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderPotato
{
    public interface IBuilderPotato : IVegetable, IPotato
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
        void SetFarmer(bool value);
        void SetCoolingMode(string value);
        SelfPotato CreatePotato();
    }
}
