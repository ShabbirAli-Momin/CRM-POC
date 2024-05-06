using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PRIOXIS_CRM_POC_.Authorization.Roles;
using PRIOXIS_CRM_POC_.Authorization.Users;
using PRIOXIS_CRM_POC_.MultiTenancy;

namespace PRIOXIS_CRM_POC_.EntityFrameworkCore
{
    public class PRIOXIS_CRM_POC_DbContext : AbpZeroDbContext<Tenant, Role, User, PRIOXIS_CRM_POC_DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PRIOXIS_CRM_POC_DbContext(DbContextOptions<PRIOXIS_CRM_POC_DbContext> options)
            : base(options)
        {
        }
    }
}
