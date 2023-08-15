using Items.Domain.Components.Entities.Categories.Vegetables.Vegetable;
using SelfBeet = Items.Domain.Components.Entities.Categories.Vegetables.BuilderBeet.Beet.Beet;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderBeet
{
    public interface IBuilderBeet : IVegetable
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
        void SetFarmer(bool value);
        SelfBeet CreateBeet();
    }
}
