using System.Threading.Tasks;

namespace LosReyes.core.Data
{
    public interface IcoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
