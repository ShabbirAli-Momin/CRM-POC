using Abp.Application.Services;
using PRIOXIS_CRM_POC_.MultiTenancy.Dto;

namespace PRIOXIS_CRM_POC_.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

