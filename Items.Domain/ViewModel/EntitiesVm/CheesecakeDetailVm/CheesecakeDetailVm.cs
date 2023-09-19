using Items.Domain.Components.Entities.Cheecakes;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.CheesecakeDetailVm
{
    public class CheesecakeDetailVm : IMapWith<Cheesecake>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public string? CoolingMode { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public float Weight { get; set; }
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }
        public int CreatedDate { get; set; }
        public string? Description { get; set; }


    }
}
