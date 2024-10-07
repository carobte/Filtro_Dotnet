using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_CarolinaBustamante.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("room_id")]
        [Column("room_id")]
        public required int RoomId { get; set; }

        
        [ForeignKey("guest_id")]
        [Column("guest_id")]
        public required int GuestId { get; set; }

        
        [ForeignKey("employee_id")]
        [Column("employee_id")]
        public required int EmployeeId { get; set; }

        [Column("start_date")]
        [Required(ErrorMessage = "Phone number is required.")]
        public DateOnly StartDate { get; set; }

        [Column("end_date")]
        public DateOnly EndDate { get; set; }
        
        [Column("total_cost")]
        [Required(ErrorMessage = "Total cost is required.")]
        public double TotalCost { get; set; }


    }
}