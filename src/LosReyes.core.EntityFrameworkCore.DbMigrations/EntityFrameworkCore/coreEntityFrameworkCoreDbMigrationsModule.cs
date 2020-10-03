using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LosReyes.core.EntityFrameworkCore
{
    [DependsOn(
        typeof(coreEntityFrameworkCoreModule)
        )]
    public class coreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<coreMigrationsDbContext>();
        }
    }
}
