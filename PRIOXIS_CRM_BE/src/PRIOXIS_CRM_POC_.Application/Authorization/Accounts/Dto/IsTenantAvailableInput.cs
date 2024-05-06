using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace PRIOXIS_CRM_POC_.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
