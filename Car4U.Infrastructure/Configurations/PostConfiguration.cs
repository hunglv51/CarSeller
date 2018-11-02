using Car4U.ApplicationCore.Entities;
using Car4U.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Configurations
{
    public class PostConfiguration : DbEntityConfiguration<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> entity)
        {
            entity.HasKey(x => x.Id);
            entity.HasMany(p => p.Notifications).WithOne(n => n.Post);
            entity.HasOne(p => p.Car).WithOne(c => c.Post);
            entity.HasOne(p => p.User).WithMany(u => u.Posts);
            entity.HasOne(p => p.Category).WithMany(c => c.Posts);
        }
    }
}
