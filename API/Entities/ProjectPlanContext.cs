using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public class ProjectPlanContext : DbContext
    {
        public ProjectPlanContext(DbContextOptions<ProjectPlanContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<BusinessUnits> BusinessUnits { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<CustomerCentricScores> CustomerCentricScores { get; set; }
        public DbSet<Divisions> Divisions { get; set; }
        public DbSet<CustomerMapCodes> CustomerMapCodes { get; set; }
        public DbSet<KeyContacts> KeyContacts { get; set; }
        public DbSet<Owners> Owners { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<TaskCategories> TaskCategories { get; set; }
    }
}
