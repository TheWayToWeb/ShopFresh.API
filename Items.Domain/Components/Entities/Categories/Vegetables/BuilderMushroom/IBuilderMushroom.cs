using Items.Domain.Components.Entities.Categories.Vegetables.Vegetable;
using SelfMushroom = Items.Domain.Components.Entities.Categories.Vegetables.BuilderMushroom.Mushroom.Mushroom;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderMushroom
{
    public interface IBuilderMushroom : IVegetable
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
        SelfMushroom CreateMushroom();
    }
}
