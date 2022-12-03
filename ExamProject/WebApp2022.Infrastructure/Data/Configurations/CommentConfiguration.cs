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
                    Title = "He stole my wallet",
                    Content = "He stole my wallet and refuses to give it back! He is a terrible person!",
                    AuthorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    ReceiverId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Comment
                {
                    Id = Guid.Parse("b09e19e1-e970-47cc-ac48-c3f9d6bc6426"),
                    Title = "He owes me money",
                    Content = "He owes me money and i decided to take them by force! He is a terrible white robber!",
                    ReceiverId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    AuthorId = "dea12856-c198-4129-b3f3-b893d8395082"
                }
            };

            builder.HasData(comments);
        }
    }
}
