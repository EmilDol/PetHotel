using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApp2022.Infrastructure.Data.Configurations
{
    internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                .HasOne(f => f.Author)
                .WithMany(f => f.CommentsWritten)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(f => f.Receiver)
                .WithMany(f => f.CommentsReceived)
                .OnDelete(DeleteBehavior.Restrict);

            var comments = new List<Comment>()
            {
                new Comment
                {
                    Id = Guid.Parse("21fd2544-3246-48bb-be99-9981c44c8836"),
                    Title = "Great babysitter",
                    Content = "Very good babysitter for pets. Would recommend if you need a babysitter for a couple of days!",
                    AuthorId = "72153552-7b85-4e34-b236-290e9bbad012",
                    ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Comment
                {
                    Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                    Title = "Don't recommend",
                    Content = "I hired Ivan to watch after my gold fish, but he killed it! He is a terrible babysitter!",
                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Comment
                {
                    Id = Guid.Parse("2892e4f0-4e16-4323-8f7c-076bcc74579e"),
                    Title = "Worst babysitter",
                    Content = "He returned my cat ill and starving! He had beaten up my cat!",
                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Comment
                {
                    Id = Guid.Parse("6f49aa38-a113-4f20-a077-9208099578ae"),
                    Title = "Can't complain",
                    Content = "He didn't just watch after my parrot, but even taugth him new words and songs!",
                    ReceiverId = "72153552-7b85-4e34-b236-290e9bbad012",
                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                }
            };

            builder.HasData(comments);
        }
    }
}
