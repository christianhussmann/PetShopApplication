using HussmannDev.PetShopApp.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
namespace HussmannDev.PetShopApp.EFCore

    
{
    public class PetApplicationDbContext : DbContext
    {
        public PetApplicationDbContext(DbContextOptions<PetApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InsuranceEntity>()
                .HasData(new InsuranceEntity {Id = 1, Name = "SafeStuff", Price = 22});
            modelBuilder.Entity<InsuranceEntity>()
                .HasData(new InsuranceEntity {Id = 1, Name = "DangStuff", Price = 10310});
            modelBuilder.Entity<InsuranceEntity>()
                .HasData(new InsuranceEntity {Id = 1, Name = "ChillStuff", Price = 70});
            modelBuilder.Entity<InsuranceEntity>()
                .HasData(new InsuranceEntity {Id = 1, Name = "KillStuff", Price = 69});
            
        }

        public DbSet<InsuranceEntity> Insurances { get; set; }
        
        
    }
}