using Microsoft.EntityFrameworkCore;

namespace Genesys_Core_API.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
           
        
        public virtual DbSet<User> Users { get; set; }
    }
}
