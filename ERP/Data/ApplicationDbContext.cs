using Microsoft.EntityFrameworkCore;
using ERP.Models.MASTER;

namespace ERP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<FRAN> FRAN { get; set; }
        public DbSet<BRCH> BRCH { get; set; }
        public DbSet<WHSE> WHSE { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<POHDR> POHDR { get; set; }
        public DbSet<PODET> PODET { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ------------------ FRAN ------------------
            modelBuilder.Entity<FRAN>()
                .HasKey(f => f.FranCode);

            // ------------------ BRCH ------------------
            modelBuilder.Entity<BRCH>()
                .HasKey(b => new { b.FranCode, b.BranchCode });

            modelBuilder.Entity<BRCH>()
                .HasOne(b => b.FRAN)
                .WithMany()
                .HasForeignKey(b => b.FranCode)
                .OnDelete(DeleteBehavior.Restrict);

            // ------------------ WHSE ------------------
            modelBuilder.Entity<WHSE>()
                .HasKey(w => new { w.FranCode, w.BranchCode, w.WhCode });

            modelBuilder.Entity<WHSE>()
                .HasOne(w => w.BRCH)
                .WithMany()
                .HasForeignKey(w => new { w.FranCode, w.BranchCode })
                .OnDelete(DeleteBehavior.Restrict);

            // ------------------ VENDOR ------------------
            modelBuilder.Entity<Vendor>()
                .HasKey(v => v.VENDOR);

            // ------------------ POHDR ------------------
            modelBuilder.Entity<POHDR>()
                .HasKey(p => new { p.FranCode, p.BranchCode, p.WhCode, p.VENDOR, p.DOCTYPE, p.DOCNO });

            modelBuilder.Entity<POHDR>()
                .HasOne(p => p.FRAN)
                .WithMany()
                .HasForeignKey(p => p.FranCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<POHDR>()
                .HasOne(p => p.BRCH)
                .WithMany()
                .HasForeignKey(p => new { p.FranCode, p.BranchCode })
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<POHDR>()
                .HasOne(p => p.WHSE)
                .WithMany()
                .HasForeignKey(p => new { p.FranCode, p.BranchCode, p.WhCode })
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<POHDR>()
                .HasOne(p => p.Vendor)
                .WithMany()
                .HasForeignKey(p => p.VENDOR)
                .OnDelete(DeleteBehavior.Restrict);

            // ------------------ PODET ------------------
            modelBuilder.Entity<PODET>()
                .HasKey(d => new { d.FranCode, d.BranchCode, d.WhCode, d.VENDOR, d.DOCTYPE, d.DOCNO, d.DOCSRL });

            modelBuilder.Entity<PODET>()
                .HasOne(d => d.FRAN)
                .WithMany()
                .HasForeignKey(d => d.FranCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PODET>()
                .HasOne(d => d.BRCH)
                .WithMany()
                .HasForeignKey(d => new { d.FranCode, d.BranchCode })
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PODET>()
                .HasOne(d => d.WHSE)
                .WithMany()
                .HasForeignKey(d => new { d.FranCode, d.BranchCode, d.WhCode })
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PODET>()
                .HasOne(d => d.Vendor)
                .WithMany()
                .HasForeignKey(d => d.VENDOR)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PODET>()
                .HasOne<POHDR>()
                .WithMany()
                .HasForeignKey(d => new { d.FranCode, d.BranchCode, d.WhCode, d.VENDOR, d.DOCTYPE, d.DOCNO })
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
