using Providers.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Providers;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ProvidersEntityFrameworkCoreTestModule)
    )]
public class ProvidersDomainTestModule : AbpModule
{

}
