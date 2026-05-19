using System.ComponentModel.DataAnnotations;

namespace Test.ServerManagement.Dtos.Servers
{
    public class ServerDto
    {
        public int ServerId { get; set; }

        public bool IsOnline { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;
    }

    public class CreateServerDto
    {
        public bool IsOnline { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;
    }
}
