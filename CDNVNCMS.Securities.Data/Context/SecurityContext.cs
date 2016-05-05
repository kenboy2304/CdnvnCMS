using System.Data.Entity;
using CDNVNONE;

namespace CDNVNCMS.Securities.Data
{
    [RegisterType(LifeTimeManager.Hierarchical)]
    public class SecurityContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new User.PersonConfiguration());

        }
    }
}
