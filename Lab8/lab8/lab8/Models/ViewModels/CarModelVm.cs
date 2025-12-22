namespace lab8.Models.ViewModels
{
    public class CarModelVm
    {
        public int Id { get; set; }
        public string CarModelName { get; set; } = null!;
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        public string Name => CarModelName;
        public string Brand => BrandName;
        public string ModelName => CarModelName;
    }
}
