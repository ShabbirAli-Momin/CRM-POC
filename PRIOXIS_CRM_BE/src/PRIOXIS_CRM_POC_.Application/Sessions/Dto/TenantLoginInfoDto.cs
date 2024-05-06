using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PRIOXIS_CRM_POC_.MultiTenancy;

namespace PRIOXIS_CRM_POC_.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
