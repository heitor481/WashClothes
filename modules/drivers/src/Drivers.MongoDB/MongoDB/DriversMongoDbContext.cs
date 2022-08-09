using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Drivers.MongoDB;

[ConnectionStringName(DriversDbProperties.ConnectionStringName)]
public class DriversMongoDbContext : AbpMongoDbContext, IDriversMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureDrivers();
    }
}
