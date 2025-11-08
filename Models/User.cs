using System.ComponentModel.DataAnnotations; //Validation atributes

namespace CineJarV2.Api.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        public bool IsActive { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Navigation property - creates realationship between tables
        //One user can have many bookings (One-to-Many relationship)
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}