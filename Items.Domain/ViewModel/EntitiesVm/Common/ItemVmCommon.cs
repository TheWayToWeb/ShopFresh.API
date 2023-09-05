namespace Items.Domain.ViewModel.EntitiesVm.Common
{
    public class ItemVmCommon
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int CountInPackage { get; set; }
        public float Weight { get; set; }
        public string? Description { get; set; }
        public bool IsFarmer { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CreatedDate { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
    }
}
