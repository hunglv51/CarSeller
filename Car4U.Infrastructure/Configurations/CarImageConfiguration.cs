using Car4U.Domain.Entities;
using Car4U.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Configurations
{
    public class CarImageConfiguration : DbEntityConfiguration<CarImage>
    {
        public override void Configure(EntityTypeBuilder<CarImage> entity)
        {
            entity.HasOne(i => i.Car).WithMany(c => c.Images);
            
        }
    }
}