using System.ComponentModel.DataAnnotations; //Data and metadata validation attributes
using System.ComponentModel.DataAnnotations.Schema; //Attributes for configuring entity mapping to a database schema

namespace CineJarV2.Api.Models
{
    public class Booking
    {
        //Primary key for Booking table
        public int Id { get; set; }

        //Foreign KEY - connects to the User table
        public int UserId { get; set; }

        //Navigation property 
        public User User { get; set; } = null!;

        [Required]
        public DateTime BookingDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime ScreeningDate { get; set; }

        [Required]
        [StringLength(50)]
        public string MovieTitle { get; set; } = string.Empty;

        [Required]
        public string SeatNumbers { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(10,2)")] 
        public decimal TotalPrice { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Pending"; //Confirmed, Cancelled

        public bool IsPaid { get; set; } = false;
    }
}