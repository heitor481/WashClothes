using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Drivers.Drivers
{
    public class Driver : FullAuditedAggregateRoot<int>, IMultiTenant
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public Guid? TenantId { get; set; }
    }
}
