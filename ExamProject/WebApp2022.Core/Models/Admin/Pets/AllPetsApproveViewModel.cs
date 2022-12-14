namespace WebApp2022.Core.Models.Admin.Pets
{
    public class AllPetsApproveViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Requirements { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Type { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Heigth { get; set; } = null!;

        public string Weigth { get; set; } = null!;

        public string Age { get; set; } = null!;
    }
}
