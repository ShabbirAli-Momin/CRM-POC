using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PRIOXIS_CRM_POC_.Controllers
{
    public abstract class PRIOXIS_CRM_POC_ControllerBase: AbpController
    {
        protected PRIOXIS_CRM_POC_ControllerBase()
        {
            LocalizationSourceName = PRIOXIS_CRM_POC_Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
