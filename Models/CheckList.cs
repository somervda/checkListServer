using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace checkListServer.Models
{
    public class CheckList
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public ICollection<CheckListItem> CheckListItems { get; set; }
    }
}