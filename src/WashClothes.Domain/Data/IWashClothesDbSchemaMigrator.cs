using System.Threading.Tasks;

namespace WashClothes.Data;

public interface IWashClothesDbSchemaMigrator
{
    Task MigrateAsync();
}
