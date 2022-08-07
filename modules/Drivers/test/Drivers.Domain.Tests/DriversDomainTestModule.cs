using Drivers.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Drivers;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(DriversEntityFrameworkCoreTestModule)
    )]
public class DriversDomainTestModule : AbpModule
{

}
