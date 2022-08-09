using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Drivers.MongoDB;

[ConnectionStringName(DriversDbProperties.ConnectionStringName)]
public interface IDriversMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
