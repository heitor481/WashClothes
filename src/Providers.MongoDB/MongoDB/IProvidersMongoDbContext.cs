using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Providers.MongoDB;

[ConnectionStringName(ProvidersDbProperties.ConnectionStringName)]
public interface IProvidersMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
