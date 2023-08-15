using pearDomain = Items.Domain.Components.Entities.Categories.Fruits.ConcretePear.Pear.Pear;

namespace Items.Domain.Components.Entities.Categories.Fruits.ConcretePear
{
    public interface IGrowerPear
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
        void SetGrade(string value);
        pearDomain CreatePear();
    }
}
