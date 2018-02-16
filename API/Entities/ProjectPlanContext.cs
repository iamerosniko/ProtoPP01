using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public class ProjectPlanContext : DbContext
    {
        public ProjectPlanContext(DbContextOptions<ProjectPlanContext> options) : base(options)
        {
            Database.Migrate();
        }

        //public DbSet<CompanyProfiles> CompanyProfiles { get; set; }

    }
}
