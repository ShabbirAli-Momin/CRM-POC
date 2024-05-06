using System.Threading.Tasks;
using Abp.Application.Services;
using PRIOXIS_CRM_POC_.Authorization.Accounts.Dto;

namespace PRIOXIS_CRM_POC_.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
