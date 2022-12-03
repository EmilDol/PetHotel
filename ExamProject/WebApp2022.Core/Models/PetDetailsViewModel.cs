using System.ComponentModel.DataAnnotations;

namespace WebApp2022.Core.Models
{
    public class PetDetailsViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Requirements { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string OwnerName { get; set; } = null!;

        public string DateStartBabysitting { get; set; } = null!;

        public string DateEndBabysitting { get; set; } = null!;

        public double Heigth { get; set; }

        public double Weigth { get; set; }

        public int Age { get; set; }

        public string Type { get; set; } = null!;
    }
}
