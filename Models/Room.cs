using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_CarolinaBustamante.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("room_number")]
        [StringLength(10)]
        [Required(ErrorMessage = "Room number is required.")]
        public required string RoomNumber { get; set; }

        [Column("price_per_night")]
        [Required(ErrorMessage = "Room price per night is required.")]
        public required double PricePerNight { get; set; }

        [Column("availability")]
        [Required(ErrorMessage = "Room availability is required.")]
        public required bool Availability { get; set; }

        [Column("max_occupancy_persons")]
        [Required(ErrorMessage = "Room max occupancy persons is required.")]
        public required int MaxOcuppancy { get; set; }

        [ForeignKey("room_type_id")]
        [Column("room_type_id")]
        public required int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}