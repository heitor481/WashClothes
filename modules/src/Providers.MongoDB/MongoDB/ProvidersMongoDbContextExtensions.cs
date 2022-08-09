using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Providers.MongoDB;

public static class ProvidersMongoDbContextExtensions
{
    public static void ConfigureProviders(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
