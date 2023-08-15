using Items.Domain.Components.Entities.Categories.Vegetables.BuilderCabbage.Cabbage;
using Items.Domain.Components.Entities.Categories.Vegetables.Vegetable;
using SelfCabbage = Items.Domain.Components.Entities.Categories.Vegetables.BuilderCabbage.Cabbage.Сabbage;
using SalesRange = Items.Domain.Components.Entities.Categories.Vegetables.Common.SalesRange;

namespace Items.Domain.Components.Entities.Categories.Vegetables.BuilderCabbage
{
    public interface IBuilderCabbage : IVegetable, ICabbage
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
        void AddSaleWeights(List<SalesRange> value);
        SelfCabbage CreateCabbage();
    }
}
