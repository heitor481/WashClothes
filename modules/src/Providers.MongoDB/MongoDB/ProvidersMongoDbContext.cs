using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Providers.MongoDB;

[ConnectionStringName(ProvidersDbProperties.ConnectionStringName)]
public class ProvidersMongoDbContext : AbpMongoDbContext, IProvidersMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureProviders();
    }
}
