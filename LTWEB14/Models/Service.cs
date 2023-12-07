using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTWEB14.Models
{
    [Table("Service")]
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public bool Status { get; set; }

    }
}
