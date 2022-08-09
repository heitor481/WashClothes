using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Providers
{
    public class Providers : FullAuditedAggregateRoot<int>, IMultiTenant
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public decimal Price { get; set; }

        public Guid? TenantId { get; set; }
    }
}
