using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace checkListServer.Models
{
    [Table("CheckListItems")]
    public class CheckListItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public CheckList CheckList { get; set; }
        public int CheckListId { get; set; }
    }
}