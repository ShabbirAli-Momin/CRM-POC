using System.Threading.Tasks;
using Abp.Application.Services;
using PRIOXIS_CRM_POC_.Sessions.Dto;

namespace PRIOXIS_CRM_POC_.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
