using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using PRIOXIS_CRM_POC_.Authorization.Users;
using PRIOXIS_CRM_POC_.Editions;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace PRIOXIS_CRM_POC_.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }

    }
}
