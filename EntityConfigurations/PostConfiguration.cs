using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI_Blog.Models;

namespace WebAPI_Blog.EntityConfigurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.Posts)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
