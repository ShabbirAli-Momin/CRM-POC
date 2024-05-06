using Abp.Application.Services.Dto;

namespace PRIOXIS_CRM_POC_.MultiTenancy.Dto
{
    public class PagedTenantResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}

