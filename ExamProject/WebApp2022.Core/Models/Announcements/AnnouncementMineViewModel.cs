namespace WebApp2022.Core.Models.Announcements
{
    public class AnnouncementMineViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public bool IsAvailable { get; set; }

        public string Price { get; set; } = null!;

        public string DateStartBabysitting { get; set; } = null!;

        public string DateEndBabysitting { get; set; } = null!;
    }
}
