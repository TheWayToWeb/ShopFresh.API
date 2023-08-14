using Items.Domain.Entities.Categories.Vegetables.ConcreteSquash.Squash;
using Items.Domain.Entities.Categories.Vegetables.Vegetable;
using SelfSquash = Items.Domain.Entities.Categories.Vegetables.ConcreteSquash.Squash.Squash;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteSquash
{
    public interface IBuilderSquash : IVegetable, ISquash
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
        void SetFarmer(bool value);
        void SetCoolingMode(string value);
        SelfSquash CreateSquash();
    }
}
