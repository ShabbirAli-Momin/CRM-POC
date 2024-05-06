using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PRIOXIS_CRM_POC_.Configuration.Dto;

namespace PRIOXIS_CRM_POC_.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PRIOXIS_CRM_POC_AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
