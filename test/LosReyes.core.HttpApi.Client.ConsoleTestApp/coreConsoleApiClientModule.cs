using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LosReyes.core.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(coreHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class coreConsoleApiClientModule : AbpModule
    {
        
    }
}
