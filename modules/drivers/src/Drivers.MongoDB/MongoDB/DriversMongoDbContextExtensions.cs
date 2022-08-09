using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Drivers.MongoDB;

public static class DriversMongoDbContextExtensions
{
    public static void ConfigureDrivers(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
