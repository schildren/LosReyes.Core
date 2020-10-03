using LosReyes.core.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LosReyes.core.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(coreEntityFrameworkCoreDbMigrationsModule),
        typeof(coreApplicationContractsModule)
        )]
    public class coreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
