using Items.Domain.Components.Entities.Categories.Vegetables.Vegetable;
using SelfSalad = Items.Domain.Components.Entities.Categories.Vegetables.BuilderSalad.Salad.Salad;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderSalad
{
    public interface IBuilderSalad : IVegetable
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
        SelfSalad CreateSalad();
    }
}
