using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL.CsvToSql
{
    public partial class CsvToSqlContext : DbContext
    {
        public CsvToSqlContext()
        {
        }

        public CsvToSqlContext(DbContextOptions<CsvToSqlContext> options)
          : base(options)
        {
        }

        public virtual DbSet<Ad> Ad { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map Add to
            modelBuilder.Entity<Ad>(entity =>
            {
                // Set primary key.
                entity.HasKey(key => key.Id);
            });
        }
    }
}
