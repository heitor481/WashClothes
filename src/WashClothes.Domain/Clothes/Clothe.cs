using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace WashClothes.Clothes
{
    public class Clothe : FullAuditedAggregateRoot<int>, IMultiTenant
    {
        public string Color { get; set; }

        public ClotheType Type { get; set; }

        public Guid? TenantId { get; set; }

        public Guid UserId { get; set; }
    }
}
