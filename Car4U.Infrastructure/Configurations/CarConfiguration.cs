using Car4U.ApplicationCore.Entities;
using Car4U.Infrastructure.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Configurations
{
    public class CarConfiguration : DbEntityConfiguration<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> entity)
        {
            
        }
    }
}