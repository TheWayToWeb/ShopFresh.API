using Items.Domain.Components.Entities.Categories.Vegetables.Vegetable;
using SelfBroccoli = Items.Domain.Components.Entities.Categories.Vegetables.BuilderBroccoli.Broccoli.Broccoli;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderBroccoli
{
    public interface IBuilderBroccoli : IVegetable
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
        SelfBroccoli CreateBroccoli();
    }
}
