using System.ComponentModel.DataAnnotations;

namespace BestStoreApp.Models
{
    public class Clients
    {
        [Key]
        public  int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        public  DateTime Created_at { get; set; }
    }
}
