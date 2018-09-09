using checkListServer.Models;
using Microsoft.EntityFrameworkCore;

namespace checkListServer.Persistence
{
    public class ChecklistDBContext : DbContext
    {
        // Constructor to pass options to base class (See Udemy mosh course section 2.3)
        public ChecklistDBContext(DbContextOptions<ChecklistDBContext> options) :
            base(options)
        {
        }

        public DbSet<CheckList> CheckLists { get; set; }
    }
}