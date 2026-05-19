using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.ServerManagement.Models
{
    public class Server
    {
        [Key]
        public int ServerId { get; set; }

        public bool IsOnline { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [ForeignKey(nameof(City))]
        public int CityId { get; set; }

        public City? City { get; set; }
    }
}
