using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using TravelEquipmentRenting.Infrastructure.Data.Configurations;

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

            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new TownConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ProductCategoryConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new RentalConfiguration());


            base.OnModelCreating(builder);
        }
    }
}