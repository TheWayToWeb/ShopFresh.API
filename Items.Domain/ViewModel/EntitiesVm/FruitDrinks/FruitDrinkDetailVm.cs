using AutoMapper;
using Items.Domain.Components.Entities.FruitDrink;
using Items.Domain.DTOs.Requests.Common;
using Items.Domain.ViewModel.EntitiesVm.Common;

namespace Items.Domain.ViewModel.EntitiesVm.FruitDrinks
{
    public class FruitDrinkDetailVm : ItemVmBase, IMapWith<FruitDrink>
    {
        public void Mapping(Profile profile)
        {
        }
    }
}
