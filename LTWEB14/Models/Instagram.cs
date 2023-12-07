using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTWEB14.Models
{
    [Table("Instagram")]
    public class Instagram
    {
        [Key]
        public int InstagramID { get; set; }
        public string? Image { get; set; }
        public bool? Status { get; set; }

    }
}
