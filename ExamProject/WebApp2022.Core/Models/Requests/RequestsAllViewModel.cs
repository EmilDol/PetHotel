namespace WebApp2022.Core.Models.Requests
{
    public class RequestsAllViewModel
    {
        public Guid Id { get; set; }

        public string BabysitterId { get; set; } = null!;

        public string BabysitterName { get; set; } = null!;

        public string BabysitterEmail { get; set; } = null!;

        public string BabysitterPhone { get; set; } = null!;
    }
}
