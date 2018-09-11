
using System.ComponentModel.DataAnnotations;

namespace checkListServer.Models
{
    public class Category
    {
 
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
    }
}