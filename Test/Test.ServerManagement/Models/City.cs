using System.ComponentModel.DataAnnotations;

namespace Test.ServerManagement.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Server> Servers { get; set; }
    }
}
