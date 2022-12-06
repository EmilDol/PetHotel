namespace WebApp2022.Core.Models.Requests
{
    public class RequestsAllViewModel
    {
        public Guid Id { get; set; }

        public string OwnerName { get; set; } = null!;

        public string OwnerEmail { get; set; } = null!;

        public string OwnerPhone { get; set; } = null!;
    }
}
