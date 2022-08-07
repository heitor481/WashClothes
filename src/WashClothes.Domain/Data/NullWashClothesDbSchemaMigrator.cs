using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WashClothes.Data;

/* This is used if database provider does't define
 * IWashClothesDbSchemaMigrator implementation.
 */
public class NullWashClothesDbSchemaMigrator : IWashClothesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
