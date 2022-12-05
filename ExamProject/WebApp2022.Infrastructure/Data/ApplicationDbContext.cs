using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebApp2022.Infrastructure.Data.Configurations;

namespace WebApp2022.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TownConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new PetConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new ReportConfiguration());
            builder.ApplyConfiguration(new AnnouncmentConfiguration());
            builder.ApplyConfiguration(new RequestConfiguration());

            base.OnModelCreating(builder);
        }
    }
}