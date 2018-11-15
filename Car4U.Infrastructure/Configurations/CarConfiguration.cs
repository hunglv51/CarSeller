using Car4U.Domain.Entities;
using Car4U.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Configurations
{
    public class CarConfiguration : DbEntityConfiguration<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> entity)
        {
            entity.HasOne(c => c.Post).WithOne(p => p.Car);
        }
    }
}