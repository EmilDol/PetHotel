namespace TravelEquipmentRenting.Core.Models
{
    public class ProductAllViewModel
    {
        public ProductAllViewModel()
        {
            Categories = new List<string>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string OwnerName { get; set; }

        public string ImageUrl { get; set; }

        public List<string> Categories { get; set; }

        public string CategoriesAsString { get; set; }
    }
}
