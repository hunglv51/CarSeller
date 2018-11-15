using Car4U.Domain.Entities;
using Car4U.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Configurations
{
    public class AppRoleConfiguration : DbEntityConfiguration<AppRole>
    {
        public override void Configure(EntityTypeBuilder<AppRole> entity)
        {
            
        }
    }
}