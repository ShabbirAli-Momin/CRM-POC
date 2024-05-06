using Abp.Authorization;
using PRIOXIS_CRM_POC_.Authorization.Roles;
using PRIOXIS_CRM_POC_.Authorization.Users;

namespace PRIOXIS_CRM_POC_.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
