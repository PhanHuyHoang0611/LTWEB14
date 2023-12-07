using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LTWEB14.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public int ReservationID { get; set; }
        public int CustomerID { get; set; }
        public string? Comment { get; set; }
        public bool? Status { get; set; }
        public int? Ratting { get; set; }
    }
}
