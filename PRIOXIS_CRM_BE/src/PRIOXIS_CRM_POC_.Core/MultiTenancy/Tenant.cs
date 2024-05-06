using Abp.MultiTenancy;
using PRIOXIS_CRM_POC_.Authorization.Users;

namespace PRIOXIS_CRM_POC_.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
