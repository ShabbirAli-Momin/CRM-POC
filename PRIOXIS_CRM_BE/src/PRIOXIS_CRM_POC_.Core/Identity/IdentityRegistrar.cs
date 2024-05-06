using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PRIOXIS_CRM_POC_.Authorization;
using PRIOXIS_CRM_POC_.Authorization.Roles;
using PRIOXIS_CRM_POC_.Authorization.Users;
using PRIOXIS_CRM_POC_.Editions;
using PRIOXIS_CRM_POC_.MultiTenancy;

namespace PRIOXIS_CRM_POC_.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
