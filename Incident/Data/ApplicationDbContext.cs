using Microsoft.EntityFrameworkCore;

namespace Incident.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.Incident> Incidents { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
