using System.ComponentModel.DataAnnotations;

namespace PRIOXIS_CRM_POC_.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
