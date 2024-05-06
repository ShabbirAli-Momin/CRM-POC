using Abp.Application.Services.Dto;

namespace PRIOXIS_CRM_POC_.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

