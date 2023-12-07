using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTWEB14.Models
{
    [Table("Room")]
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public string? Description { get; set; }
        public string? Vieww { get; set; }
        public string? Size
        {
            get;set;
        }
        public int Bed { get; set; }
        public string? Image { get; set; }
        public bool? Status { get; set; }
    }
}
