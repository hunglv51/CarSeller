using Car4U.Domain.Entities;
using Car4U.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Configurations
{
    public class PostCategoryConfiguration : DbEntityConfiguration<PostCategory>
    {
        public override void Configure(EntityTypeBuilder<PostCategory> entity)
        {
            entity.HasMany(c => c.Posts).WithOne(p => p.Category);
        }
    }
}