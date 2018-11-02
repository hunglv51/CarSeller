using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car4U.Infrastructure.Data.Extensions{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<T>(this ModelBuilder modelBuilder, DbEntityConfiguration<T> dbEntityConfiguration)  where T : class
        {
            modelBuilder.Entity<T>(dbEntityConfiguration.Configure);
        }
    }

    public abstract class DbEntityConfiguration<T> where T: class{
        public abstract void Configure(EntityTypeBuilder<T> entity);
    }
}