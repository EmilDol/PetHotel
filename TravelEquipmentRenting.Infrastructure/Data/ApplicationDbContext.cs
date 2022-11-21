using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TravelEquipmentRenting.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Rental> Rentals { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductCategory> ProductsCategories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<ProductCategory>()
                .HasKey(k => new { k.CategoryId, k.ProductId });

            builder
                .Entity<Product>()
                .Property(p => p.IsApproved)
                .HasDefaultValue(false);
            
            builder
                .Entity<Product>()
                .Property(p => p.IsAvailable)
                .HasDefaultValue(true);

            builder.Entity<Comment>()
                .HasOne(f => f.Author)
                .WithMany(f => f.CommentsWritten)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Entity<Comment>()
                .HasOne(f => f.Receiver)
                .WithMany(f => f.CommentsReceived)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Rental>()
                .HasOne(f => f.Product)
                .WithOne(f => f.Rental)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}