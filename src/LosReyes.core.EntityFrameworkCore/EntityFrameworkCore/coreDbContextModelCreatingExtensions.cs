using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace LosReyes.core.EntityFrameworkCore
{
    public static class coreDbContextModelCreatingExtensions
    {
        public static void Configurecore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(coreConsts.DbTablePrefix + "YourEntities", coreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}