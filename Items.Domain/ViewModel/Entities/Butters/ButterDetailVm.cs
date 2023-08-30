using AutoMapper;
using Items.Domain.Components.Entities.Butter;
using Items.Domain.Components.Entities.Common;
using Items.Domain.DTOs.Requests.Common;
using Items.Domain.ViewModel.Entities.Common;

namespace Items.Domain.ViewModel.Entities.Butters
{
    public class ButterDetailVm : ItemVmBase, IMapWith<Butter>
    {
        public List<ProductTaste> Tastes { get; set; } = new();
        public List<FatContentProduct> FatContents { get; set; } = new();
        public bool IsVegan { get; set; }

        public void Mapping(Profile profile)
        {
        }
    }
}
