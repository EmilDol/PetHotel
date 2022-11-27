namespace TravelEquipmentRenting.Core.Models
{
    public class ProductDetailsViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string OwnerName { get; set; }

        public string OwnerPhone { get; set; }

        public string OwnerEmail { get; set; }

        public string ImageUrl { get; set; }

        public string DateAdded { get; set; }

        public decimal PricePerDay { get; set; }

        public string CategoriesAsString { get; set; }
    }
}
