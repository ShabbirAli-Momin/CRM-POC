using System.ComponentModel.DataAnnotations;

namespace PRIOXIS_CRM_POC_.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}