using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTWEB14.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string? Title { get; set; }
        public string? Contents { get; set; }
        public DateTime PublishDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
