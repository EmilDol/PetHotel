namespace WebApp2022.Core.Models
{
    public class PetMineViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Requirements { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string IsApproved { get; set; }

        public string Type { get; set; } = null!;
    }
}
