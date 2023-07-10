using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Bread
{
    public abstract class Bread : Eat
    {
        public string? KindOfBread { get; set; }
        public string? Feature { get; set; }
        public string? Addition { get; set; }
        public string? TypeOfFlour { get; set; }
    }
}
