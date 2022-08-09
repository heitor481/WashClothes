using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Drivers.EntityFrameworkCore;

[ConnectionStringName(DriversDbProperties.ConnectionStringName)]
public interface IDriversDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
