using Car4U.Domain.Entities;
using Car4U.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Configurations
{
    public class AppUserConfiguration : DbEntityConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> entity)
        {
            entity.HasMany(u => u.Posts).WithOne(p => p.User);
            entity.HasMany(u => u.Notifications).WithOne(n => n.User);
        }
    }
}