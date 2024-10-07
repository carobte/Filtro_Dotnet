using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Filtro_Dotnet.Models
{
    [Table("room_types")]
    public class RoomType
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Room name is required.")]      
        public required string Name { get; set; }
        
        [Column("description")]
        [StringLength(255)]        
        public string Description { get; set; }
        
        public ICollection<Room> Rooms { get; set; }


    }
}