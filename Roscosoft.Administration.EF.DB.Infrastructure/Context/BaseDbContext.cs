using Microsoft.EntityFrameworkCore;
using Roscosoft.Administration.Library.Entites;

namespace Roscosoft.Administration.EF.DB.Infrastructure.Context
{
    public class BaseDbContext : DbContext
    {
        public virtual DbSet<NewEntity> News { get; set; }
        public DbContextOptions Options { get; }

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewEntity>()
                .HasKey(x => x.IdNew);

            base.OnModelCreating(modelBuilder);
        }
    }
}
