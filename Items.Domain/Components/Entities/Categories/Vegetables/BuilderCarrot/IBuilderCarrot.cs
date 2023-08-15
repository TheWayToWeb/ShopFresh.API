using Items.Domain.Components.Entities.Categories.Vegetables.BuilderCarrot.Carrot;
using Items.Domain.Components.Entities.Categories.Vegetables.Vegetable;
using SelfCarrot = Items.Domain.Components.Entities.Categories.Vegetables.BuilderCarrot.Carrot.Carrot;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderCarrot
{
    public interface IBuilderCarrot : IVegetable, ICarrot
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
        void SetCoolingMode(string value);
        void SetFarmer(bool value);
        SelfCarrot CreateCarrot();
    }
}
