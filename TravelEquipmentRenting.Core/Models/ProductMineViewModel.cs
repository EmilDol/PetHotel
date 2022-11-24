namespace TravelEquipmentRenting.Core.Models
{
    public class ProductMineViewModel
    {
        public ProductMineViewModel()
        {
            Categories = new List<string>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<string> Categories { get; set; }

        public string CategoriesAsString { get; set; }

        public string IsAvailable { get; set; }

        public string IsApproved { get; set; }
    }
}
