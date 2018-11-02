using Car4U.ApplicationCore.Entities;
using Car4U.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Configurations
{
    public class NotificationConfiguration : DbEntityConfiguration<Notification>
    {
        public override void Configure(EntityTypeBuilder<Notification> entity)
        {
            entity.HasKey(n => n.Id);
            entity.HasOne(n => n.Post).WithMany(p => p.Notifications);
            entity.HasOne(n => n.User).WithMany(u => u.Notifications);
        }
    }
}