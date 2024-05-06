using System.Threading.Tasks;
using PRIOXIS_CRM_POC_.Configuration.Dto;

namespace PRIOXIS_CRM_POC_.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
