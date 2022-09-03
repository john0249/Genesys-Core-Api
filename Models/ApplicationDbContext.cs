using Microsoft.EntityFrameworkCore;

namespace Genesys_Core_API.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
