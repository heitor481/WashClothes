using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Providers.EntityFrameworkCore;

[ConnectionStringName(ProvidersDbProperties.ConnectionStringName)]
public interface IProvidersDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
