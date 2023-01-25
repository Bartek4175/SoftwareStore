using System.ComponentModel.DataAnnotations;

namespace SoftwareStore.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public DateTime FoundingDate { get; set; }
        public string slug { get; set; }
    }
}
