using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LosReyes.core.Data
{
    /* This is used if database provider does't define
     * IcoreDbSchemaMigrator implementation.
     */
    public class NullcoreDbSchemaMigrator : IcoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}