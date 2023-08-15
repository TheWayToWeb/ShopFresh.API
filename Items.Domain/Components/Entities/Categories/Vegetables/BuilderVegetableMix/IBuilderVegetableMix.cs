using Items.Domain.Components.Entities.Categories.Vegetables.BuilderVegetableMix.VegetableMix;
using SelfVegetableMix = Items.Domain.Components.Entities.Categories.Vegetables.BuilderVegetableMix.VegetableMix.VegetableMix;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderVegetableMix
{
    public interface IBuilderVegetableMix : IVegetableMix
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
        SelfVegetableMix CreateVegetableMix();
    }
}
