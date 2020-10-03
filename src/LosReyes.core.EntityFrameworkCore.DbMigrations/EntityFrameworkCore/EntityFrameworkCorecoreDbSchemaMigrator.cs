using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LosReyes.core.Data;
using Volo.Abp.DependencyInjection;

namespace LosReyes.core.EntityFrameworkCore
{
    public class EntityFrameworkCorecoreDbSchemaMigrator
        : IcoreDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorecoreDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the coreMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<coreMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}