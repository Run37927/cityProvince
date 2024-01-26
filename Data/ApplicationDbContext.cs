using cityProvinceMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cityProvinceMVC.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Province> Provinces { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Configure the City entity
        builder.Entity<City>(entity =>
        {
            entity.HasKey(c => c.CityId);
            entity.Property(c => c.CityName).IsRequired().HasMaxLength(50);
            entity.Property(c => c.Population).IsRequired();
            entity.HasOne(c => c.Province)
                  .WithMany(p => p.Cities)
                  .HasForeignKey(c => c.ProvinceCode);
            entity.ToTable("City");
        });

        // Configure the Province entity
        builder.Entity<Province>(entity =>
        {
            entity.HasKey(p => p.ProvinceCode);
            entity.Property(p => p.ProvinceName).IsRequired().HasMaxLength(50);
            entity.ToTable("Province");
        });

        // Seed method can be included if you want to pre-populate the database
        builder.Seed(); 
    }
}
