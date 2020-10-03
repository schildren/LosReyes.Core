using Volo.Abp.Modularity;

namespace LosReyes.core
{
    [DependsOn(
        typeof(coreApplicationModule),
        typeof(coreDomainTestModule)
        )]
    public class coreApplicationTestModule : AbpModule
    {

    }
}