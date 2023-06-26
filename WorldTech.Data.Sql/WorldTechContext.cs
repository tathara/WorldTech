using Microsoft.EntityFrameworkCore;

namespace WorldTech.Data.Sql
{
    public class WorldTechContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WorldTech.db");
        }

        public DbSet<ProductEntity> Products => Set<ProductEntity>();
        public DbSet<CheckEntity> Checks => Set<CheckEntity>();
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public WorldTechContext() => Database.EnsureCreated();

    }
}
