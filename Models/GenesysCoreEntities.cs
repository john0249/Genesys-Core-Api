using Microsoft.EntityFrameworkCore;


namespace Genesys_Core_API.Models
{
    public partial class GenesysCoreEntities : DbContext
    {
        public GenesysCoreEntities() : base()
        {

        }

        public virtual DbSet<Users>? Users { get; set; }
        
    }
}
