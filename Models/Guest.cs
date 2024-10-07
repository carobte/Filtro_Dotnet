using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_CarolinaBustamante.Models
{
    [Table("guests")]
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("first_name")]
        [StringLength(255)]
        [Required(ErrorMessage = "First name is required.")]      
        public required string FirstName { get; set; }

        [Column("last_name")]
        [StringLength(255)]
        [Required(ErrorMessage = "Last name is required.")]      
        public required string LastName { get; set; }

        [Column("email")]
        [StringLength(255)]
        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]      
        public required string Email { get; set; }

        [Column("identification_number")]
        [StringLength(20)]
        [Required(ErrorMessage = "Identification number is required.")]      
        public required string IdNumber { get; set; }
        
        [Column("phone_number")]
        [StringLength(20)]
        [Required(ErrorMessage = "Phone number is required.")]      
        public required string Phone { get; set; }

        [Column("birthdate")]
        public DateOnly BirthDate { get;set;}
        public ICollection<Booking> Bookings { get; set; }

    }
}