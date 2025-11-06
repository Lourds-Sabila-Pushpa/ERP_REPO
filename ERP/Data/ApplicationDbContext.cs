using Microsoft.EntityFrameworkCore;
using ERP.Models.MASTER;

namespace ERP.Data // 👈 You can adjust this if your folder name is just "Data"
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // ✅ Add your DbSets (tables)
        public DbSet<FRAN> FRAN { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 👇 Optional: add precision, relationships, or constraints here
            // Example:
            // modelBuilder.Entity<FRAN>()
            //     .Property(f => f.Id)
            //     .HasColumnType("numeric(22, 0)");
        }
    }
}
