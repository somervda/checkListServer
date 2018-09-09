using System.Collections.Generic;
using System.Collections.ObjectModel;
using checkListServer.Models;

namespace checkListServer.Controllers.Resources
{
    public class CheckListResource
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<CheckListItemResource> CheckListItems { get; set; }

        public CheckListResource()
        {
            CheckListItems = new Collection<CheckListItemResource>();
        }
    }
}