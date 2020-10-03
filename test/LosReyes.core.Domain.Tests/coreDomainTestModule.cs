using LosReyes.core.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LosReyes.core
{
    [DependsOn(
        typeof(coreEntityFrameworkCoreTestModule)
        )]
    public class coreDomainTestModule : AbpModule
    {

    }
}